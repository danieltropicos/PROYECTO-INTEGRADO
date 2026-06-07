using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;


public static class AlmacenJsonCifrado
{
    private const string CarpetaData = "Data";
    private const string LlaveCifrado = "GeoTerra-ProyectoIntegrador-2026";
    private static readonly byte[] Key = SHA256.HashData(Encoding.UTF8.GetBytes(LlaveCifrado));
    private static readonly JsonSerializerOptions OpcionesLectura = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private static readonly JsonSerializerOptions OpcionesEscritura = new()
    {
        WriteIndented = false
    };

    public static string RutaArchivo(string nombreArchivo) =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, nombreArchivo);

    public static bool Existe(string nombreArchivo) =>
        File.Exists(RutaArchivo(nombreArchivo));

    public static T? Cargar<T>(string nombreArchivo)
    {
        var ruta = RutaArchivo(nombreArchivo);
        if (!File.Exists(ruta))
            return default;

        var cifrado = File.ReadAllText(ruta);
        var json = Descifrar(cifrado);
        return JsonSerializer.Deserialize<T>(json, OpcionesLectura);
    }

    public static void Guardar<T>(string nombreArchivo, T datos)
    {
        var ruta = RutaArchivo(nombreArchivo);
        Directory.CreateDirectory(Path.GetDirectoryName(ruta)!);

        var json = JsonSerializer.Serialize(datos, OpcionesEscritura);
        var cifrado = Cifrar(json);
        File.WriteAllText(ruta, cifrado);
    }

    private static string Cifrar(string textoPlano)
    {
        using var aes = Aes.Create();
        aes.Key = Key;
        aes.GenerateIV();

        using var encryptor = aes.CreateEncryptor();
        var bytesPlano = Encoding.UTF8.GetBytes(textoPlano);
        var bytesCifrado = encryptor.TransformFinalBlock(bytesPlano, 0, bytesPlano.Length);

        var resultado = new byte[aes.IV.Length + bytesCifrado.Length];
        Buffer.BlockCopy(aes.IV, 0, resultado, 0, aes.IV.Length);
        Buffer.BlockCopy(bytesCifrado, 0, resultado, aes.IV.Length, bytesCifrado.Length);

        return Convert.ToBase64String(resultado);
    }

    private static string Descifrar(string textoCifrado)
    {
        var datos = Convert.FromBase64String(textoCifrado);

        using var aes = Aes.Create();
        aes.Key = Key;

        var iv = new byte[16];
        var cipher = new byte[datos.Length - iv.Length];
        Buffer.BlockCopy(datos, 0, iv, 0, iv.Length);
        Buffer.BlockCopy(datos, iv.Length, cipher, 0, cipher.Length);
        aes.IV = iv;

        using var decryptor = aes.CreateDecryptor();
        var bytesPlano = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
        return Encoding.UTF8.GetString(bytesPlano);
    }
}
