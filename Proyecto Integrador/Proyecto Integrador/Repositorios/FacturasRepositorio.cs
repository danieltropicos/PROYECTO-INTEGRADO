using Proyecto_Integrador.Modelos.Facturas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios
{
    internal class FacturasRepositorio
    {
        public static readonly string carpeta = "Facturas.json";
        public static readonly string ruta = Path.Combine(carpeta, "estudiante.json");


        private List<Factura> Leer()
        {
            List<Factura> lista = new List<Factura>();
            if (File.Exists(ruta))
            {
                using (var sr = new StreamReader(ruta))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Factura>>(json) ?? lista;
                    }
                }

            }
            else
            {
                Directory.CreateDirectory(carpeta);
                File.WriteAllText(ruta, "[]");
            }
            return lista;
        }

        public void Guardar(List<Factura> lista)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            using (var sw = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(lista, opciones);
                sw.Write(json);
            }
        }

        public void Agregar(Factura factura)
        {
            var lista = Leer();
            lista.Add(factura);
            Guardar(lista);
        }

        public List<Factura> Listar()
        {
            var lista = Leer();
            return lista;
       
        }

    }
}
