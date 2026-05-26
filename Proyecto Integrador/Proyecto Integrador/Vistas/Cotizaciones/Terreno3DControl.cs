using OpenTK;
using OpenTK.Graphics.OpenGL;
using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class Terreno3DControl : UserControl
{
    private GLControl glControl;
    private Label _lblTitulo;

    private List<PuntoTerreno> puntos = [];

    // ─────────────────────────────────────────────
    // CÁMARA MEJORADA
    // ─────────────────────────────────────────────
    private float rotacionX = 55f;
    private float rotacionY = -45f;
    private float zoom = -140f;

    private Point ultimoMouse;
    private bool arrastrando = false;

    public string Titulo { get; private set; } = "Terreno";

    public enum TipoTerreno
    {
        Original,
        Final
    }

    public TipoTerreno Tipo { get; private set; }

    private float _zMin = 0f;
    private float _zMax = 1f;

    public Terreno3DControl(TipoTerreno tipo = TipoTerreno.Original)
    {
        Tipo = tipo;

        Titulo = tipo == TipoTerreno.Original
            ? "Terreno Original"
            : "Terreno Final";

        InitializeComponent();
        InicializarOpenGL();
    }

    // ─────────────────────────────────────────────
    // INIT
    // ─────────────────────────────────────────────

    private void InicializarOpenGL()
    {
        glControl = new GLControl
        {
            Dock = DockStyle.Fill
        };

        _lblTitulo = new Label
        {
            Text = Titulo,
            ForeColor = Color.White,
            BackColor = Color.FromArgb(150, 20, 20, 24),
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            AutoSize = true,
            Padding = new Padding(8, 4, 8, 4),
            Location = new Point(8, 6)
        };

        Controls.Add(glControl);
        Controls.Add(_lblTitulo);

        _lblTitulo.BringToFront();

        glControl.Load += GlControl_Load;
        glControl.Paint += GlControl_Paint;
        glControl.Resize += GlControl_Resize;

        glControl.MouseDown += GlControl_MouseDown;
        glControl.MouseUp += GlControl_MouseUp;
        glControl.MouseMove += GlControl_MouseMove;
        glControl.MouseWheel += GlControl_MouseWheel;
    }

    private void GlControl_Load(object? sender, EventArgs e)
    {
        glControl.MakeCurrent();

        // Fondo oscuro profesional
        GL.ClearColor(Color.FromArgb(18, 22, 30));

        GL.Enable(EnableCap.DepthTest);

        GL.Enable(EnableCap.Blend);
        GL.BlendFunc(
            BlendingFactor.SrcAlpha,
            BlendingFactor.OneMinusSrcAlpha);

        GL.Enable(EnableCap.LineSmooth);
        GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest);

        GL.Enable(EnableCap.PolygonOffsetFill);
        GL.PolygonOffset(1f, 1f);

        // Mejor render
        //GL.Enable(EnableCap.CullFace);
        //GL.CullFace(CullFaceMode.Back);

        GL.ShadeModel(ShadingModel.Smooth);

        // Fog cinematográfico
        GL.Enable(EnableCap.Fog);

        float[] fogColor = { 0.10f, 0.12f, 0.16f, 1.0f };

        GL.Fog(FogParameter.FogColor, fogColor);
        GL.Fog(FogParameter.FogMode, (int)FogMode.Linear);

        // Mucho más suave
        GL.Fog(FogParameter.FogStart, 260f);
        GL.Fog(FogParameter.FogEnd, 420f);

        ConfigurarVista();
    }

    private void GlControl_Resize(object? sender, EventArgs e)
    {
        glControl.MakeCurrent();

        ConfigurarVista();

        glControl.Invalidate();
    }

    private void ConfigurarVista()
    {
        GL.Viewport(0, 0, glControl.Width, glControl.Height);

        float aspect =
            glControl.Width /
            (float)Math.Max(glControl.Height, 1);

        Matrix4 perspectiva =
            Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f),
                aspect,
                0.1f,
                1000f);

        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadMatrix(ref perspectiva);

        GL.MatrixMode(MatrixMode.Modelview);
    }

    // ─────────────────────────────────────────────
    // RENDER
    // ─────────────────────────────────────────────

    private void GlControl_Paint(object? sender, PaintEventArgs e)
    {
        glControl.MakeCurrent();

        GL.Clear(
            ClearBufferMask.ColorBufferBit |
            ClearBufferMask.DepthBufferBit);

        GL.LoadIdentity();

        GL.Translate(0f, -10f, zoom);

        GL.Rotate(rotacionX, 1f, 0f, 0f);
        GL.Rotate(rotacionY, 0f, 1f, 0f);

        if (puntos.Count < 4)
        {
            DibujarGrid();
        }

        DibujarEjes();

        if (puntos.Count >= 4)
        {
            DibujarPisoBase();
            DibujarParedes();
            DibujarTerreno();

            if (Tipo == TipoTerreno.Final)
            {
                DibujarFondoHueco();
            }

            DibujarContornos();
        }

        glControl.SwapBuffers();
    }

    // ─────────────────────────────────────────────
    // TERRENO
    // ─────────────────────────────────────────────

    private void DibujarTerreno()
    {
        var filas = ObtenerFilas(puntos);

        GL.Begin(PrimitiveType.Triangles);

        for (int y = 0; y < filas.Count - 1; y++)
        {
            var actual = filas[y];
            var siguiente = filas[y + 1];

            int cols = Math.Min(
                actual.Count,
                siguiente.Count);

            for (int x = 0; x < cols - 1; x++)
            {
                var p1 = actual[x];
                var p2 = actual[x + 1];
                var p3 = siguiente[x];
                var p4 = siguiente[x + 1];

                bool esFondo =
                    Tipo == TipoTerreno.Final &&
                    p1.Z <= -20 &&
                    p2.Z <= -20 &&
                    p3.Z <= -20 &&
                    p4.Z <= -20;

                if (!esFondo)
                {
                    DibujarTrianguloConShading(p1, p2, p3);
                    DibujarTrianguloConShading(p2, p4, p3);
                }
            }
        }

        GL.End();
    }

    private void DibujarTrianguloConShading(
        PuntoTerreno a,
        PuntoTerreno b,
        PuntoTerreno c)
    {
        var va = new Vector3((float)a.X, (float)a.Z, (float)a.Y);
        var vb = new Vector3((float)b.X, (float)b.Z, (float)b.Y);
        var vc = new Vector3((float)c.X, (float)c.Z, (float)c.Y);

        Vector3 edge1 = vb - va;
        Vector3 edge2 = vc - va;

        Vector3 normal = Vector3.Cross(edge1, edge2);

        if (normal.LengthSquared > 0.00001f)
        {
            normal.Normalize();

            // IMPORTANTE:
            // fuerza las normales a apuntar hacia arriba
            if (normal.Y < 0)
                normal = -normal;
        }

        var luz = Vector3.Normalize(
            new Vector3(0.4f, 1f, 0.3f));

        float difuso =
            Math.Clamp(Vector3.Dot(normal, luz), 0f, 1f);

        // MÁS CONTRASTE
        float brillo = 0.75f + 0.25f * difuso;

        ColorConBrillo(
            (float)((a.Z + b.Z + c.Z) / 3.0),
            brillo);

        GL.Vertex3(va);
        GL.Vertex3(vb);
        GL.Vertex3(vc);
    }

    // ─────────────────────────────────────────────
    // COLOR
    // ─────────────────────────────────────────────

    private void ColorConBrillo(float zMedia, float brillo)
    {
        float rango = Math.Max(_zMax - _zMin, 0.001f);

        float t =
            Math.Clamp(
                (zMedia - _zMin) / rango,
                0f,
                1f);

        float r;
        float g;
        float b;

        bool esFondoHueco =
            Tipo == TipoTerreno.Final &&
            Math.Abs(zMedia - _zMin) < 0.5f;

        if (esFondoHueco)
        {
            // Fondo uniforme azul
            GL.Color4(
                0.10f,
                0.35f,
                0.95f,
                1f);

            return;
        }

        // ───────────────── ORIGINAL
        if (Tipo == TipoTerreno.Original)
        {
            // Verde topográfico vivo

            if (t < 0.25f)
            {
                float l = t / 0.25f;

                r = 0.05f;
                g = 0.45f + 0.25f * l;
                b = 0.05f;
            }
            else if (t < 0.55f)
            {
                float l = (t - 0.25f) / 0.30f;

                r = 0.10f + 0.35f * l;
                g = 0.70f + 0.20f * l;
                b = 0.05f;
            }
            else if (t < 0.80f)
            {
                float l = (t - 0.55f) / 0.25f;

                r = 0.45f + 0.45f * l;
                g = 0.90f - 0.20f * l;
                b = 0.05f;
            }
            else
            {
                float l = (t - 0.80f) / 0.20f;

                r = 0.90f;
                g = 0.70f - 0.25f * l;
                b = 0.05f;
            }
        }

        // ───────────────── FINAL
        else
        {
            // Excavación azul/cian brillante

            if (t < 0.25f)
            {
                float l = t / 0.25f;

                r = 0.03f;
                g = 0.15f + 0.15f * l;
                b = 0.45f + 0.40f * l;
            }
            else if (t < 0.60f)
            {
                float l = (t - 0.25f) / 0.35f;

                r = 0.08f + 0.12f * l;
                g = 0.30f + 0.45f * l;
                b = 0.85f;
            }
            else
            {
                float l = (t - 0.60f) / 0.40f;

                r = 0.20f + 0.45f * l;
                g = 0.75f + 0.15f * l;
                b = 0.90f - 0.20f * l;
            }
        }

        GL.Color4(
            r * brillo,
            g * brillo,
            b * (0.55f + 0.45f * brillo),
            0.98f);
    }

    // ─────────────────────────────────────────────
    // PISO BASE
    // ─────────────────────────────────────────────

    private void DibujarPisoBase()
    {
        if (puntos.Count == 0)
            return;

        float xMin = (float)puntos.Min(p => p.X);
        float xMax = (float)puntos.Max(p => p.X);

        float yMin = (float)puntos.Min(p => p.Y);
        float yMax = (float)puntos.Max(p => p.Y);

        float baseY = Math.Min(_zMin, 0f);

        GL.Begin(PrimitiveType.Quads);

        GL.Color4(0.12f, 0.12f, 0.14f, 0.85f);

        GL.Vertex3(xMin, baseY, yMin);
        GL.Vertex3(xMax, baseY, yMin);
        GL.Vertex3(xMax, baseY, yMax);
        GL.Vertex3(xMin, baseY, yMax);

        GL.End();
    }

    private void DibujarFondoHueco()
    {
        if (Tipo != TipoTerreno.Final)
            return;

        // Coordenadas del hueco
        float xMin = -20;
        float xMax = 20;

        float yMin = -20;
        float yMax = 20;

        // Profundidad del fondo
        float z = -20;

        GL.Disable(EnableCap.Texture2D);

        GL.Begin(PrimitiveType.Quads);

        // Azul uniforme limpio
        GL.Color4(0.08f, 0.35f, 0.95f, 1f);

        GL.Vertex3(xMin, z, yMin);
        GL.Vertex3(xMax, z, yMin);
        GL.Vertex3(xMax, z, yMax);
        GL.Vertex3(xMin, z, yMax);

        GL.End();
    }

    // ─────────────────────────────────────────────
    // PAREDES
    // ─────────────────────────────────────────────

    private void DibujarParedes()
    {
        var filas = ObtenerFilas(puntos);

        if (filas.Count < 2)
            return;

        float baseY = Math.Min(_zMin, 0f);

        void ParedQuad(PuntoTerreno p1, PuntoTerreno p2)
        {
            ColorConBrillo((float)p1.Z, 0.55f);
            Vertex(p1);

            ColorConBrillo((float)p2.Z, 0.55f);
            Vertex(p2);

            GL.Color4(0.02f, 0.02f, 0.03f, 1f);
            GL.Vertex3((float)p2.X, baseY, (float)p2.Y);

            GL.Color4(0.02f, 0.02f, 0.03f, 1f);
            GL.Vertex3((float)p1.X, baseY, (float)p1.Y);
        }

        GL.Begin(PrimitiveType.Quads);

        var primera = filas[0];

        for (int x = 0; x < primera.Count - 1; x++)
            ParedQuad(primera[x], primera[x + 1]);

        var ultima = filas[^1];

        for (int x = 0; x < ultima.Count - 1; x++)
            ParedQuad(ultima[x], ultima[x + 1]);

        for (int y = 0; y < filas.Count - 1; y++)
            ParedQuad(filas[y][0], filas[y + 1][0]);

        for (int y = 0; y < filas.Count - 1; y++)
            ParedQuad(filas[y][^1], filas[y + 1][^1]);

        GL.End();
    }

    // ─────────────────────────────────────────────
    // CONTORNOS
    // ─────────────────────────────────────────────

    private void DibujarContornos()
    {
        var filas = ObtenerFilas(puntos);

        GL.LineWidth(2.2f);

        GL.Begin(PrimitiveType.Lines);

        GL.Color4(1f, 1f, 1f, 0.30f);

        for (int y = 0; y < filas.Count - 1; y++)
        {
            var actual = filas[y];
            var siguiente = filas[y + 1];

            int cols = Math.Min(
                actual.Count,
                siguiente.Count);

            for (int x = 0; x < cols - 1; x++)
            {
                Vertex(actual[x]);
                Vertex(actual[x + 1]);

                Vertex(actual[x]);
                Vertex(siguiente[x]);
            }
        }

        GL.End();
    }

    // ─────────────────────────────────────────────
    // GRID
    // ─────────────────────────────────────────────

    private void DibujarGrid()
    {
        GL.Disable(EnableCap.DepthTest);

        GL.LineWidth(0.5f);

        GL.Begin(PrimitiveType.Lines);

        GL.Color4(0.18f, 0.18f, 0.22f, 0.55f);

        int size = 200;
        int step = 10;

        for (int i = -size; i <= size; i += step)
        {
            GL.Vertex3(i, -0.01f, -size);
            GL.Vertex3(i, -0.01f, size);

            GL.Vertex3(-size, -0.01f, i);
            GL.Vertex3(size, -0.01f, i);
        }

        GL.End();

        GL.Enable(EnableCap.DepthTest);
    }

    // ─────────────────────────────────────────────
    // EJES
    // ─────────────────────────────────────────────

    private void DibujarEjes()
    {
        GL.LineWidth(2f);

        GL.Begin(PrimitiveType.Lines);

        // X
        GL.Color3(Color.FromArgb(220, 60, 60));
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(30, 0, 0);

        // Y altura
        GL.Color3(Color.FromArgb(60, 200, 80));
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(0, 30, 0);

        // Z profundidad
        GL.Color3(Color.FromArgb(60, 120, 220));
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(0, 0, 30);

        GL.End();
    }

    // ─────────────────────────────────────────────
    // UTILS
    // ─────────────────────────────────────────────

    private static List<List<PuntoTerreno>> ObtenerFilas(
        List<PuntoTerreno> pts)
    {
        return pts
            .GroupBy(p => p.Y)
            .OrderBy(g => g.Key)
            .Select(g => g.OrderBy(p => p.X).ToList())
            .ToList();
    }

    private void Vertex(PuntoTerreno p)
    {
        GL.Vertex3(
            (float)p.X,
            (float)p.Z,
            (float)p.Y);
    }

    // ─────────────────────────────────────────────
    // API
    // ─────────────────────────────────────────────

    public void ActualizarTerreno(
        List<PuntoTerreno> nuevosPuntos)
    {
        puntos = nuevosPuntos;

        if (puntos.Count > 0)
        {
            _zMin = (float)puntos.Min(p => p.Z);
            _zMax = (float)puntos.Max(p => p.Z);

            if (Math.Abs(_zMax - _zMin) < 0.001f)
            {
                _zMin -= 1f;
                _zMax += 1f;
            }
        }

        if (glControl.IsHandleCreated)
        {
            glControl.MakeCurrent();
            glControl.Invalidate();
        }
    }

    // ─────────────────────────────────────────────
    // MOUSE
    // ─────────────────────────────────────────────

    private void GlControl_MouseDown(
        object? sender,
        MouseEventArgs e)
    {
        arrastrando = true;
        ultimoMouse = e.Location;
    }

    private void GlControl_MouseUp(
        object? sender,
        MouseEventArgs e)
    {
        arrastrando = false;
    }

    private void GlControl_MouseMove(
        object? sender,
        MouseEventArgs e)
    {
        if (!arrastrando)
            return;

        rotacionY += (e.X - ultimoMouse.X) * 0.5f;
        rotacionX += (e.Y - ultimoMouse.Y) * 0.5f;

        ultimoMouse = e.Location;

        glControl.MakeCurrent();
        glControl.Invalidate();
    }

    private void GlControl_MouseWheel(
        object? sender,
        MouseEventArgs e)
    {
        zoom += e.Delta * 0.02f;

        glControl.MakeCurrent();
        glControl.Invalidate();
    }
}