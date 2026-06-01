using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Cotizaciones;

namespace Proyecto_Integrador.Services;

public static class TerrenoImagenCapturaService
{
    public static byte[]? Capturar(
        IReadOnlyList<PuntoTerreno> puntos,
        Terreno3DControl.TipoTerreno tipo)
    {
        if (puntos.Count < 3)
            return null;

        byte[]? resultado = null;
        Exception? error = null;

        void CapturarEnUi()
        {
            Form? host = null;
            Terreno3DControl? control = null;

            try
            {
                host = new Form
                {
                    Size = new Size(660, 460),
                    ShowInTaskbar = false,
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(-5000, -5000)
                };

                control = new Terreno3DControl(tipo)
                {
                    Size = new Size(640, 430),
                    Location = new Point(10, 10)
                };

                host.Controls.Add(control);
                host.Show();
                host.Refresh();

                for (var i = 0; i < 300; i++)
                {
                    Application.DoEvents();
                    if (control.EstaListo)
                        break;
                }

                if (!control.EstaListo)
                    throw new InvalidOperationException("No se pudo inicializar el visor 3D.");

                control.ActualizarTerreno(puntos);

                for (var i = 0; i < 30; i++)
                    Application.DoEvents();

                resultado = control.CapturarImagen();
            }
            catch (Exception ex)
            {
                error = ex;
                resultado = null;
            }
            finally
            {
                control?.Dispose();
                host?.Close();
                host?.Dispose();
            }
        }

        if (Application.OpenForms.Count > 0)
        {
            var main = Application.OpenForms[0]!;
            if (main.InvokeRequired)
                main.Invoke(CapturarEnUi);
            else
                CapturarEnUi();
        }
        else
        {
            CapturarEnUi();
        }

        if (resultado == null && error != null)
            System.Diagnostics.Debug.WriteLine($"Captura 3D fallida: {error.Message}");

        return resultado;
    }
}
