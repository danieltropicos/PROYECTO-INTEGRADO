namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class UiHelper
    {
        private static readonly Color AzulPrincipal = Color.FromArgb(30, 58, 95);
        private static readonly Color AzulSecundario = Color.FromArgb(59, 93, 122);
        private static readonly Color NaranjaPrincipal = Color.FromArgb(245, 158, 11);
        private static readonly Font FuenteBoton = new("Segoe UI", 10F);
        private const int AnchoMinimoAccion = 56;

        public static void MarcarBotonSidebarActivo(Button? activo, params Button[] todos)
        {
            foreach (var boton in todos)
            {
                bool esActivo = boton == activo;
                boton.BackColor = esActivo ? AzulSecundario : AzulPrincipal;
                boton.Font = esActivo ? new Font(FuenteBoton, FontStyle.Bold) : FuenteBoton;
            }
        }

        public static void EstilizarBotonNavbar(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = AzulSecundario;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
        }

        public static void EstilizarPanelTarjeta(Panel panel) =>
            panel.BackColor = Color.White;

        public static void EstilizarEtiquetaRol(Label label)
        {
            label.BackColor = NaranjaPrincipal;
            label.ForeColor = Color.White;
            label.Padding = new Padding(12, 6, 12, 6);
            label.AutoSize = true;
        }

        /// <summary>
        /// Columnas de datos reparten el ancho disponible; las de iconos quedan fijas al final (sin cortarse).
        /// </summary>
        public static void ConfigurarColumnasGrid(DataGridView grid, params DataGridViewColumn[] columnasAccion)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grid.ScrollBars = ScrollBars.Both;

            foreach (var col in columnasAccion)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                var ancho = AnchoColumnaAccion(grid, col);
                col.Width = ancho;
                col.MinimumWidth = ancho;
            }

            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (!col.Visible || columnasAccion.Contains(col)) continue;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                col.MinimumWidth = 70;
            }

            void Ajustar(object? s, EventArgs e) => AjustarAnchosColumnas(grid, columnasAccion);

            grid.Resize += Ajustar;
            grid.RowsAdded += Ajustar;
            grid.RowsRemoved += Ajustar;
            Ajustar(null, EventArgs.Empty);
        }

        public static void AjustarAnchosColumnas(DataGridView grid, params DataGridViewColumn[] columnasAccion)
        {
            var acciones = columnasAccion.Where(c => c.Visible).ToList();
            var datos = grid.Columns.Cast<DataGridViewColumn>()
                .Where(c => c.Visible && !acciones.Contains(c))
                .ToList();

            if (datos.Count == 0) return;

            int anchoAcciones = 0;
            foreach (var col in acciones)
            {
                var ancho = AnchoColumnaAccion(grid, col);
                col.Width = ancho;
                anchoAcciones += ancho;
            }
            int anchoBarra = AnchoBarraVertical(grid);
            int disponible = grid.ClientSize.Width - anchoAcciones - anchoBarra - 3;

            if (disponible <= 0)
            {
                foreach (var col in datos)
                    col.Width = col.MinimumWidth;
                return;
            }

            int minimoTotal = datos.Sum(c => c.MinimumWidth);
            if (disponible <= minimoTotal)
            {
                foreach (var col in datos)
                    col.Width = col.MinimumWidth;
                return;
            }

            int extra = disponible - minimoTotal;
            int extraPorColumna = extra / datos.Count;
            int resto = extra % datos.Count;

            for (int i = 0; i < datos.Count; i++)
                datos[i].Width = datos[i].MinimumWidth + extraPorColumna + (i < resto ? 1 : 0);
        }

        private static int AnchoColumnaAccion(DataGridView grid, DataGridViewColumn col)
        {
            var fuente = grid.ColumnHeadersDefaultCellStyle.Font ?? grid.Font;
            var texto = string.IsNullOrEmpty(col.HeaderText) ? "Acciones" : col.HeaderText;
            var anchoTexto = TextRenderer.MeasureText(texto, fuente).Width + 24;
            return Math.Max(AnchoMinimoAccion, anchoTexto);
        }

        private static int AnchoBarraVertical(DataGridView grid)
        {
            foreach (Control control in grid.Controls)
            {
                if (control is VScrollBar barra && barra.Visible)
                    return barra.Width;
            }

            return 0;
        }
    }
}

