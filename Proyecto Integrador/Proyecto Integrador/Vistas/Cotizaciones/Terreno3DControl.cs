using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones;


public partial class Terreno3DControl : UserControl
{
    private GLControl _gl = null!;
    private bool _ready;

    private List<PuntoTerreno> _puntos = [];
    private double[,]? _Z;
    private Vector3[,]? _N;
    private float[] _xs = [];
    private float[] _ys = [];

    private float _xMin, _xMax, _yMin, _yMax, _zMin, _zMax;
    private float _cx, _cy, _cz, _scale;

    private float _camTheta = 45f;
    private float _camPhi = 35f;
    private float _camDist = 4.0f;
    private float _panX, _panY;

    private Point _lastMouse;
    private bool _lmb, _rmb;

    private static readonly Vector3 LUZ = Vector3.Normalize(new Vector3(1f, 0.8f, 2f));

    public Terreno3DControl()
    {
        Init();
    }

    private void Init()
    {
        var titulo = new Label
        {
            Text = "Terreno",
            Dock = DockStyle.Top,
            Height = 26,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
            BackColor = Color.FromArgb(30, 58, 95),
            ForeColor = Color.White
        };

        _gl = new GLControl(new GraphicsMode(32, 24, 0, 4))
        {
            Dock = DockStyle.Fill,
            VSync = true
        };

        _gl.Load += OnLoad;
        _gl.Resize += OnResize;
        _gl.Paint += OnPaint;
        _gl.MouseDown += OnMouseDown;
        _gl.MouseMove += OnMouseMove;
        _gl.MouseUp += OnMouseUp;
        _gl.MouseWheel += OnMouseWheel;
        _gl.DoubleClick += (_, _) => { _camTheta = 45f; _camPhi = 35f; _camDist = 4f; _panX = 0; _panY = 0; _gl.Invalidate(); };

        Controls.Add(_gl);
        Controls.Add(titulo);
    }

    public bool EstaListo => _ready;

    public void ActualizarTerreno(IEnumerable<PuntoTerreno> puntos)
    {
        _puntos = puntos.ToList();
        Reconstruir();
        if (_ready) _gl.Invalidate();
    }

    private void Reconstruir()
    {
        _Z = null; _N = null;

        if (_puntos.Count < 3) { BB(); return; }

        var uxs = _puntos.Select(p => (float)p.X).Distinct().OrderBy(v => v).ToArray();
        var uys = _puntos.Select(p => (float)p.Y).Distinct().OrderBy(v => v).ToArray();

        if ((long)uxs.Length * uys.Length != _puntos.Count) { BB(); return; }

        _xs = uxs; _ys = uys;
        int nx = _xs.Length, ny = _ys.Length;

        _Z = new double[nx, ny];
        var dic = _puntos.ToDictionary(p => ((float)p.X, (float)p.Y), p => p.Z);
        for (int xi = 0; xi < nx; xi++)
            for (int yi = 0; yi < ny; yi++)
                _Z[xi, yi] = dic.TryGetValue((_xs[xi], _ys[yi]), out double z) ? z : 0;

        CalcNormals();
        BB();
    }

    private void CalcNormals()
    {
        int nx = _xs.Length, ny = _ys.Length;
        _N = new Vector3[nx, ny];

        for (int xi = 0; xi < nx - 1; xi++)
            for (int yi = 0; yi < ny - 1; yi++)
            {
                // Quad corners
                var v00 = P(xi, yi);
                var v10 = P(xi + 1, yi);
                var v01 = P(xi, yi + 1);
                var v11 = P(xi + 1, yi + 1);

                // Normal del quad (antihorario desde +Z)
                // Cross(A→B, A→D) con A=v00, B=v10, D=v01
                Vector3 n = Normalize(Vector3.Cross(v10 - v00, v01 - v00));

                _N[xi, yi] += n;
                _N[xi + 1, yi] += n;
                _N[xi, yi + 1] += n;
                _N[xi + 1, yi + 1] += n;
            }

        for (int xi = 0; xi < nx; xi++)
            for (int yi = 0; yi < ny; yi++)
                _N[xi, yi] = Normalize(_N[xi, yi]);
    }

    private Vector3 P(int xi, int yi) =>
        new(_xs[xi], _ys[yi], (float)_Z![xi, yi]);

    private static Vector3 Normalize(Vector3 v)
    {
        float l = v.Length;
        return l > 1e-7f ? v / l : Vector3.UnitZ;
    }

    private void BB()
    {
        if (_puntos.Count == 0)
        {
            _cx = _cy = _cz = 0; _scale = 1;
            _xMin = _yMin = _zMin = -10; _xMax = _yMax = _zMax = 10;
            return;
        }
        _xMin = (float)_puntos.Min(p => p.X); _xMax = (float)_puntos.Max(p => p.X);
        _yMin = (float)_puntos.Min(p => p.Y); _yMax = (float)_puntos.Max(p => p.Y);
        _zMin = (float)_puntos.Min(p => p.Z); _zMax = (float)_puntos.Max(p => p.Z);

        if (_zMax - _zMin < 0.5f) { _zMin -= 0.5f; _zMax += 0.5f; }

        _cx = (_xMin + _xMax) / 2f;
        _cy = (_yMin + _yMax) / 2f;
        _cz = (_zMin + _zMax) / 2f;

        float span = Math.Max(Math.Max(_xMax - _xMin, _yMax - _yMin), _zMax - _zMin);
        _scale = 1.7f / Math.Max(span, 1f);
    }

    private static (float r, float g, float b) Paleta(float t)
    {
        t = Math.Clamp(t, 0f, 1f);
        ReadOnlySpan<(float r, float g, float b)> stops =
        [
            (0.05f, 0.18f, 0.55f),
            (0.05f, 0.65f, 0.75f),
            (0.15f, 0.72f, 0.25f),
            (0.95f, 0.85f, 0.10f),
            (0.88f, 0.12f, 0.08f),
        ];

        float seg = t * (stops.Length - 1);
        int i = Math.Min((int)seg, stops.Length - 2);
        float s = seg - i;
        return (
            stops[i].r + (stops[i + 1].r - stops[i].r) * s,
            stops[i].g + (stops[i + 1].g - stops[i].g) * s,
            stops[i].b + (stops[i + 1].b - stops[i].b) * s
        );
    }

    private (float r, float g, float b) ColorIluminado(int xi, int yi)
    {
        float z = (float)_Z![xi, yi];
        float t = (_zMax > _zMin) ? (z - _zMin) / (_zMax - _zMin) : 0.5f;
        var (r, g, b) = Paleta(t);

        float ambient = 0.35f;
        float diffuse = 0.65f;
        Vector3 n = _N![xi, yi];
        float dot = Math.Max(0f, Vector3.Dot(n, LUZ));
        float factor = ambient + diffuse * dot;

        return (
            Math.Clamp(r * factor, 0f, 1f),
            Math.Clamp(g * factor, 0f, 1f),
            Math.Clamp(b * factor, 0f, 1f)
        );
    }

    private void OnLoad(object? s, EventArgs e)
    {
        _ready = true;
        _gl.MakeCurrent();

        GL.ClearColor(0.07f, 0.10f, 0.15f, 1f);
        GL.Enable(EnableCap.DepthTest);
        GL.DepthFunc(DepthFunction.Lequal);
        GL.Enable(EnableCap.Blend);
        GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        GL.ShadeModel(ShadingModel.Smooth);

        GL.Disable(EnableCap.Lighting);

        if (_puntos.Count > 0)
            Reconstruir();

        OnResize(s, e);
        _gl.Invalidate();
    }

    private void OnResize(object? s, EventArgs e)
    {
        if (!_ready) return;
        _gl.MakeCurrent();
        int w = Math.Max(_gl.Width, 1), h = Math.Max(_gl.Height, 1);
        GL.Viewport(0, 0, w, h);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        var proj = Matrix4.CreatePerspectiveFieldOfView(
            MathHelper.DegreesToRadians(40f), (float)w / h, 0.001f, 200f);
        GL.LoadMatrix(ref proj);
        GL.MatrixMode(MatrixMode.Modelview);
    }

    private void OnPaint(object? s, PaintEventArgs e)
    {
        if (!_ready) return;

        RenderEscenaGl(_gl.Width, _gl.Height);
        _gl.SwapBuffers();

        using var g = _gl.CreateGraphics();
        DibujarLeyenda(g);
        DibujarEtiquetasEjes(g);   // <── agregar esta línea
        DibujarHint(g);
    }
    private void DibujarEtiquetasEjes(Graphics g)
    {
        if (_puntos.Count == 0) return;

        using var f = new Font("Segoe UI", 7f);
        using var brX = new SolidBrush(Color.FromArgb(230, 230, 80, 80));
        using var brY = new SolidBrush(Color.FromArgb(230, 80, 210, 80));
        using var brZ = new SolidBrush(Color.FromArgb(230, 100, 160, 255));

        float piso = _zMin - (_zMax - _zMin) * 0.10f;
        const int PASOS = 8;

        // Etiquetas X
        for (int i = 0; i <= PASOS; i++)
        {
            float xv = _xMin + (_xMax - _xMin) * i / PASOS;
            if (Project(new Vector3(xv, _yMin, piso), out PointF sp))
                g.DrawString($"{xv:F1}", f, brX, sp.X - 12, sp.Y + 2);
        }

        // Etiquetas Y
        for (int i = 0; i <= PASOS; i++)
        {
            float yv = _yMin + (_yMax - _yMin) * i / PASOS;
            if (Project(new Vector3(_xMin, yv, piso), out PointF sp))
                g.DrawString($"{yv:F1}", f, brY, sp.X + 3, sp.Y - 8);
        }

        // Etiquetas Z
        const int TICKS = 5;
        float tickLen = (_xMax - _xMin) * 0.03f;
        for (int i = 0; i <= TICKS; i++)
        {
            float zv = _zMin + (_zMax - _zMin) * i / TICKS;
            if (Project(new Vector3(_xMin - tickLen, _yMin, zv), out PointF sp))
                g.DrawString($"{zv:F1}", f, brZ, sp.X - 30, sp.Y - 6);
        }
    }

    /// <summary>
    /// Proyecta un punto del mundo 3D a coordenadas de pantalla.
    /// Devuelve false si está fuera del frustum.
    /// </summary>
    private bool Project(Vector3 world, out PointF screen)
    {
        screen = PointF.Empty;

        // Aplicar la misma transformación que en RenderEscenaGl
        var translated = new Vector3(
            (world.X - _cx) * _scale + _panX,
            (world.Y - _cy) * _scale + _panY,
            (world.Z - _cz) * _scale);

        float thetaRad = MathHelper.DegreesToRadians(_camTheta);
        float phiRad = MathHelper.DegreesToRadians(_camPhi);
        float eyeX = _camDist * (float)(Math.Cos(phiRad) * Math.Cos(thetaRad));
        float eyeY = _camDist * (float)(Math.Cos(phiRad) * Math.Sin(thetaRad));
        float eyeZ = _camDist * (float)Math.Sin(phiRad);

        var view = Matrix4.LookAt(new Vector3(eyeX, eyeY, eyeZ), Vector3.Zero, Vector3.UnitZ);
        var proj = Matrix4.CreatePerspectiveFieldOfView(
            MathHelper.DegreesToRadians(40f),
            (float)_gl.Width / _gl.Height, 0.001f, 200f);

        var clip = Vector4.Transform(new Vector4(translated, 1f), view * proj);
        if (Math.Abs(clip.W) < 1e-7f) return false;

        var ndc = new Vector3(clip.X / clip.W, clip.Y / clip.W, clip.Z / clip.W);
        if (ndc.Z < -1f || ndc.Z > 1f) return false;

        screen = new PointF(
            (ndc.X + 1f) * 0.5f * _gl.Width,
            (1f - (ndc.Y + 1f) * 0.5f) * _gl.Height);
        return true;
    }

    private void RenderEscenaGl(int ancho, int alto)
    {
        _gl.MakeCurrent();
        GL.Viewport(0, 0, Math.Max(ancho, 1), Math.Max(alto, 1));
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        float thetaRad = MathHelper.DegreesToRadians(_camTheta);
        float phiRad = MathHelper.DegreesToRadians(_camPhi);

        float eyeX = _camDist * (float)(Math.Cos(phiRad) * Math.Cos(thetaRad));
        float eyeY = _camDist * (float)(Math.Cos(phiRad) * Math.Sin(thetaRad));
        float eyeZ = _camDist * (float)Math.Sin(phiRad);

        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        var proj = Matrix4.CreatePerspectiveFieldOfView(
            MathHelper.DegreesToRadians(40f),
            (float)Math.Max(ancho, 1) / Math.Max(alto, 1),
            0.001f,
            200f);
        GL.LoadMatrix(ref proj);

        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadIdentity();

        var view = Matrix4.LookAt(
            new Vector3(eyeX, eyeY, eyeZ),
            Vector3.Zero,
            Vector3.UnitZ);
        GL.LoadMatrix(ref view);

        GL.Translate(_panX, _panY, 0f);
        GL.Scale(_scale, _scale, _scale);
        GL.Translate(-_cx, -_cy, -_cz);

        if (_Z != null)
        {
            // DibujarBase(); Desactivada para poder visualizar hundiduras
            DibujarSuperficie();
            DibujarWireframe();
            DibujarEjes();
        }
        else
        {
            DibujarNube();
        }
    }

    private void DibujarBase()
    {
        float piso = _zMin - (_zMax - _zMin) * 0.10f;
        int nx = _xs.Length, ny = _ys.Length;

        GL.Color3(0.11f, 0.14f, 0.19f);
        GL.Begin(PrimitiveType.Quads);
        GL.Vertex3(_xMin, _yMin, piso);
        GL.Vertex3(_xMax, _yMin, piso);
        GL.Vertex3(_xMax, _yMax, piso);
        GL.Vertex3(_xMin, _yMax, piso);
        GL.End();

        GL.Color3(0.17f, 0.20f, 0.27f);

        GL.Begin(PrimitiveType.QuadStrip);
        for (int xi = 0; xi < nx; xi++)
        {
            GL.Vertex3(_xs[xi], _yMin, piso);
            GL.Vertex3(_xs[xi], _yMin, (float)_Z![xi, 0]);
        }
        GL.End();

        GL.Begin(PrimitiveType.QuadStrip);
        for (int xi = nx - 1; xi >= 0; xi--)
        {
            GL.Vertex3(_xs[xi], _yMax, piso);
            GL.Vertex3(_xs[xi], _yMax, (float)_Z![xi, ny - 1]);
        }
        GL.End();


        GL.Begin(PrimitiveType.QuadStrip);
        for (int yi = ny - 1; yi >= 0; yi--)
        {
            GL.Vertex3(_xMin, _ys[yi], piso);
            GL.Vertex3(_xMin, _ys[yi], (float)_Z![0, yi]);
        }
        GL.End();

        GL.Begin(PrimitiveType.QuadStrip);
        for (int yi = 0; yi < ny; yi++)
        {
            GL.Vertex3(_xMax, _ys[yi], piso);
            GL.Vertex3(_xMax, _ys[yi], (float)_Z![nx - 1, yi]);
        }
        GL.End();
    }

    private void DibujarSuperficie()
    {
        GL.PolygonOffset(1f, 1f);
        GL.Enable(EnableCap.PolygonOffsetFill);

        int nx = _xs.Length, ny = _ys.Length;

        for (int xi = 0; xi < nx - 1; xi++)
        {
            GL.Begin(PrimitiveType.QuadStrip);
            for (int yi = 0; yi < ny; yi++)
            {
                var (r0, g0, b0) = ColorIluminado(xi, yi);
                var (r1, g1, b1) = ColorIluminado(xi + 1, yi);

                GL.Color3(r0, g0, b0);
                GL.Vertex3(_xs[xi], _ys[yi], (float)_Z![xi, yi]);

                GL.Color3(r1, g1, b1);
                GL.Vertex3(_xs[xi + 1], _ys[yi], (float)_Z![xi + 1, yi]);
            }
            GL.End();
        }

        GL.Disable(EnableCap.PolygonOffsetFill);
    }

    private void DibujarWireframe()
    {
        GL.LineWidth(0.8f);
        GL.Color4(0f, 0f, 0f, 0.22f);
        const float OFF = 0.02f;
        int nx = _xs.Length, ny = _ys.Length;

        for (int yi = 0; yi < ny; yi++)
        {
            GL.Begin(PrimitiveType.LineStrip);
            for (int xi = 0; xi < nx; xi++)
                GL.Vertex3(_xs[xi], _ys[yi], (float)_Z![xi, yi] + OFF);
            GL.End();
        }

        for (int xi = 0; xi < nx; xi++)
        {
            GL.Begin(PrimitiveType.LineStrip);
            for (int yi = 0; yi < ny; yi++)
                GL.Vertex3(_xs[xi], _ys[yi], (float)_Z![xi, yi] + OFF);
            GL.End();
        }
        GL.LineWidth(1f);
    }

    private void DibujarEjes()
    {
        float piso = _zMin - (_zMax - _zMin) * 0.10f;
        float extXY = (_xMax - _xMin) * 0.07f;
        float extZ = (_zMax - _zMin) * 0.15f;

        // ── Ejes principales ──────────────────────────────────────────
        GL.LineWidth(2f);
        GL.Begin(PrimitiveType.Lines);
        GL.Color3(0.9f, 0.2f, 0.2f);
        GL.Vertex3(_xMin, _yMin, piso); GL.Vertex3(_xMax + extXY, _yMin, piso);
        GL.Color3(0.2f, 0.85f, 0.2f);
        GL.Vertex3(_xMin, _yMin, piso); GL.Vertex3(_xMin, _yMax + extXY, piso);
        GL.Color3(0.35f, 0.6f, 1.0f);
        GL.Vertex3(_xMin, _yMin, piso); GL.Vertex3(_xMin, _yMin, _zMax + extZ);
        GL.End();
        GL.LineWidth(1f);

        // ── Cuadrícula base (plano XY en piso) ───────────────────────
        DibujarCuadriculaBase(piso);

        // ── Ticks de Z (líneas horizontales en eje Z) ─────────────────
        DibujarTicksZ(piso);
    }

    private void DibujarCuadriculaBase(float piso)
    {
        GL.LineWidth(0.6f);
        GL.Color4(0.4f, 0.5f, 0.6f, 0.35f);  // gris-azulado semitransparente

        const int PASOS = 8;

        // Líneas paralelas al eje Y (varían en X)
        GL.Begin(PrimitiveType.Lines);
        for (int i = 0; i <= PASOS; i++)
        {
            float x = _xMin + (_xMax - _xMin) * i / PASOS;
            GL.Vertex3(x, _yMin, piso);
            GL.Vertex3(x, _yMax, piso);
        }
        // Líneas paralelas al eje X (varían en Y)
        for (int i = 0; i <= PASOS; i++)
        {
            float y = _yMin + (_yMax - _yMin) * i / PASOS;
            GL.Vertex3(_xMin, y, piso);
            GL.Vertex3(_xMax, y, piso);
        }
        GL.End();

        GL.LineWidth(1f);
    }

    private void DibujarTicksZ(float piso)
    {
        const int TICKS = 5;
        float tickLen = (_xMax - _xMin) * 0.03f;

        GL.LineWidth(1.2f);
        GL.Color3(0.35f, 0.6f, 1.0f);
        GL.Begin(PrimitiveType.Lines);
        for (int i = 0; i <= TICKS; i++)
        {
            float z = _zMin + (_zMax - _zMin) * i / TICKS;
            // pequeña marca horizontal en el eje Z
            GL.Vertex3(_xMin, _yMin, z);
            GL.Vertex3(_xMin - tickLen, _yMin, z);
        }
        GL.End();
        GL.LineWidth(1f);
    }

    private void DibujarNube()
    {
        GL.PointSize(5f);
        GL.Begin(PrimitiveType.Points);
        foreach (var p in _puntos)
        {
            float t = (_zMax > _zMin) ? (float)((p.Z - _zMin) / (_zMax - _zMin)) : 0.5f;
            var (r, g, b) = Paleta(t);
            GL.Color3(r, g, b);
            GL.Vertex3((float)p.X, (float)p.Y, (float)p.Z);
        }
        GL.End();
        GL.PointSize(1f);
    }

    private void DibujarLeyenda(Graphics g)
    {
        if (_puntos.Count == 0) return;
        const int W = 16, H = 140;
        int x = _gl.Width - 60;
        int y = (_gl.Height - H) / 2;

        // Barra de gradiente
        for (int i = 0; i < H; i++)
        {
            float t = 1f - (float)i / H;   // arriba = caliente
            var (r, gr, b) = Paleta(t);
            using var pen = new Pen(Color.FromArgb(255,
                (int)(r * 255), (int)(gr * 255), (int)(b * 255)));
            g.DrawLine(pen, x, y + i, x + W, y + i);
        }

        g.DrawRectangle(new Pen(Color.FromArgb(180, 255, 255, 255)), x, y, W, H);

        using var fv = new Font("Segoe UI", 7f);
        using var br = new SolidBrush(Color.White);
        for (int i = 0; i <= 5; i++)
        {
            float t = (float)i / 5;
            float zv = _zMin + t * (_zMax - _zMin);
            int py = y + H - (int)(t * H);
            g.DrawString($"{zv:F1}", fv, br, x + W + 3, py - 6);
        }
        using var ft = new Font("Segoe UI", 7.5f, FontStyle.Bold);
        g.DrawString("Z (m)", ft, br, x, y - 16);
    }

    private void DibujarHint(Graphics g)
    {
        using var f = new Font("Segoe UI", 7f);
        using var br = new SolidBrush(Color.FromArgb(100, 255, 255, 255));
        g.DrawString("Rotar: LMB  |  Pan: RMB  |  Zoom: Rueda  |  Reset: 2×clic",
            f, br, 6, _gl.Height - 17);
    }

    private void OnMouseDown(object? s, MouseEventArgs e)
    {
        _lastMouse = e.Location;
        _lmb = e.Button == MouseButtons.Left;
        _rmb = e.Button == MouseButtons.Right;
    }

    private void OnMouseMove(object? s, MouseEventArgs e)
    {
        if (!_lmb && !_rmb) return;
        float dx = e.X - _lastMouse.X;
        float dy = e.Y - _lastMouse.Y;

        if (_lmb)
        {
            _camTheta -= dx * 0.4f;
            _camPhi = Math.Clamp(_camPhi + dy * 0.4f, -89f, 89f);
        }
        if (_rmb)
        {
            _panX += dx * 0.003f;
            _panY -= dy * 0.003f;
        }

        _lastMouse = e.Location;
        _gl.Invalidate();
    }

    private void OnMouseUp(object? s, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left) _lmb = false;
        if (e.Button == MouseButtons.Right) _rmb = false;
    }

    private void OnMouseWheel(object? s, MouseEventArgs e)
    {
        _camDist = Math.Clamp(_camDist * (e.Delta > 0 ? 0.88f : 1.13f), 0.3f, 40f);
        _gl.Invalidate();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing) _gl?.Dispose();
        base.Dispose(disposing);
    }
    public byte[] CapturarImagen(int ancho = 0, int alto = 0)
    {
        if (!_ready)
            throw new InvalidOperationException("El visor 3D aún no está listo.");

        int w = ancho > 0 ? ancho : Math.Max(_gl.Width, 1);
        int h = alto > 0 ? alto : Math.Max(_gl.Height, 1);

        _gl.MakeCurrent();
        RenderEscenaGl(w, h);

        byte[] pixels = new byte[w * h * 3];
        GL.ReadPixels(0, 0, w, h, PixelFormat.Rgb, PixelType.UnsignedByte, pixels);

        using var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
            {
                int src = ((h - 1 - y) * w + x) * 3;
                bmp.SetPixel(x, y, Color.FromArgb(pixels[src], pixels[src + 1], pixels[src + 2]));
            }

        using var ms = new MemoryStream();
        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        return ms.ToArray();
    }
}