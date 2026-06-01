using Proyecto_Integrador.Modelos.Cotizaciones;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class CotizacionRepositorio
{
    const string CarpetaData = "Data";
    private static readonly string RutaArchivo = 
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, "cotizaciones.json");
   
    private readonly List<Cotizacion> cotizaciones = [];

    public CotizacionRepositorio()
    {        
        CargarCotizaciones();
    }

    public void AgregarCotizacion(Cotizacion cotizacion)
    {
        cotizaciones.Add(cotizacion);
        GuardarCotizaciones();
    }

    public List<Cotizacion> ObtenerCotizaciones() => cotizaciones;

    public void ActualizarCotizacion(Cotizacion cotizacion)
    {
        var index = cotizaciones.FindIndex(c => c.Id == cotizacion.Id);
        if (index >= 0)
        {
            cotizaciones[index] = cotizacion;
            GuardarCotizaciones();
        }
    }

    private void GuardarCotizaciones()
    {
        Directory.CreateDirectory(CarpetaData);

        var options = new JsonSerializerOptions 
        { 
            WriteIndented = true 
        };        
        
        using (var writer = new StreamWriter(RutaArchivo))
        {
            var json = JsonSerializer.Serialize(cotizaciones, options);
            writer.Write(json);
        }
    }

    private void CargarCotizaciones()
    {
        if (!File.Exists(RutaArchivo)) return;

        var opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        using (var reader = new StreamReader(RutaArchivo))
        {
            var json = reader.ReadToEnd();
            var cotizacionesCargadas = JsonSerializer.Deserialize<List<Cotizacion>>(json, opciones);
            if (cotizacionesCargadas != null)
            {
                cotizaciones.AddRange(cotizacionesCargadas);
            }
        }
    }
}
