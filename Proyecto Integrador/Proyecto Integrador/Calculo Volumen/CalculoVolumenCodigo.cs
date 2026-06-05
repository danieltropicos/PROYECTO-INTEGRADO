using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Calculo_Volumen
{
    internal class CalculoVolumenCodigo
    {
        public double CalcularVolumenExcavacion(List<double[]> puntosInicio)
        {
            // ─── 1. Construir la malla ────────────────────────────────────────────────
            var xs = puntosInicio.Select(p => p[0]).Distinct().OrderBy(v => v).ToList();
            var ys = puntosInicio.Select(p => p[1]).Distinct().OrderBy(v => v).ToList();

            if (xs.Count < 2 || ys.Count < 2)
                throw new InvalidOperationException(
                    "Se necesitan al menos 2 valores distintos de X e Y para integrar.");

            // ─── 2. Diccionario del terreno ───────────────────────────────────────────
            var zInicio = new Dictionary<(double, double), double>();
            foreach (var p in puntosInicio)
                zInicio[(p[0], p[1])] = p[2];

            // ─── 3. Integración doble — nivel de referencia Z=0 ──────────────────────
            //
            //   V = ∫∫ Z(x,y) dA  ≈  Σᵢ Σⱼ [ (Z₀₀ + Z₁₀ + Z₀₁ + Z₁₁) / 4 ] · Δx · Δy

            double volumenTotal = 0.0;

            for (int i = 0; i < xs.Count - 1; i++)
            {
                for (int j = 0; j < ys.Count - 1; j++)
                {
                    double x0 = xs[i], x1 = xs[i + 1];
                    double y0 = ys[j], y1 = ys[j + 1];

                    double dx = x1 - x0;
                    double dy = y1 - y0;

                    // Z de cada esquina (el "final" es 0, así que ΔZ = Z_inicial)
                    zInicio.TryGetValue((x0, y0), out double z00);
                    zInicio.TryGetValue((x1, y0), out double z10);
                    zInicio.TryGetValue((x0, y1), out double z01);
                    zInicio.TryGetValue((x1, y1), out double z11);

                    double zPromedio = (z00 + z10 + z01 + z11) / 4.0;
                    volumenTotal += zPromedio * dx * dy;
                }
            }
            return volumenTotal;
        }
    }
}
