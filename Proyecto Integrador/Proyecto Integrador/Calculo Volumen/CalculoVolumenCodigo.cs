using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Calculo_Volumen
{
    internal class CalculoVolumenCodigo
    {
        public double CalcularVolumenExcavacion(List<double[]> puntosInicio)
        {
            var xs = puntosInicio.Select(p => p[0]).Distinct().OrderBy(v => v).ToList();
            var ys = puntosInicio.Select(p => p[1]).Distinct().OrderBy(v => v).ToList();

            if (xs.Count < 2 || ys.Count < 2)
                throw new InvalidOperationException(
                    "Se necesitan al menos 2 valores distintos de X e Y para integrar.");

            var zInicio = new Dictionary<(double, double), double>();
            foreach (var p in puntosInicio)
                zInicio[(p[0], p[1])] = p[2];

            double volumenTotal = 0.0;

            for (int i = 0; i < xs.Count - 1; i++)
            {
                for (int j = 0; j < ys.Count - 1; j++)
                {
                    double x0 = xs[i], x1 = xs[i + 1];
                    double y0 = ys[j], y1 = ys[j + 1];

                    double dx = x1 - x0;
                    double dy = y1 - y0;

                    zInicio.TryGetValue((x0, y0), out double z00);
                    zInicio.TryGetValue((x1, y0), out double z10);
                    zInicio.TryGetValue((x0, y1), out double z01);
                    zInicio.TryGetValue((x1, y1), out double z11);

                    // ✅ Math.Abs para que Z negativos no arruinen el resultado
                    double zPromedio = (Math.Abs(z00) + Math.Abs(z10) + Math.Abs(z01) + Math.Abs(z11)) / 4.0;
                    volumenTotal += zPromedio * dx * dy;
                }
            }

            return volumenTotal;
        }
    }
}
