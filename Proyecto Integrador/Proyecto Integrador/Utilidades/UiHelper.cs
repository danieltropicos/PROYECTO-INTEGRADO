namespace Proyecto_Integrador.Utilidades
{
    public static class UiHelper
    {
        public static void EstilizarBotonSidebar(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = AppTheme.AzulPrincipal;
            boton.ForeColor = AppTheme.Blanco;
            boton.Font = AppTheme.FuenteBoton;
            boton.Cursor = Cursors.Hand;
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.Padding = new Padding(20, 0, 0, 0);
            boton.Height = 48;
            boton.FlatAppearance.MouseOverBackColor = AppTheme.AzulSecundario;
            boton.UseVisualStyleBackColor = false;
        }

        public static void MarcarBotonSidebarActivo(Button activo, params Button[] todos)
        {
            foreach (var boton in todos)
            {
                bool esActivo = boton == activo;
                boton.BackColor = esActivo ? AppTheme.AzulSecundario : AppTheme.AzulPrincipal;
                boton.Font = esActivo
                    ? new Font(AppTheme.FuenteBoton, FontStyle.Bold)
                    : AppTheme.FuenteBoton;
            }
        }

        public static void EstilizarBotonPrimario(Button boton) =>
            AplicarEstiloBoton(boton, AppTheme.NaranjaPrincipal, AppTheme.Blanco, AppTheme.NaranjaOscuro);

        public static void EstilizarBotonSecundario(Button boton) =>
            AplicarEstiloBoton(boton, AppTheme.FondoSecundario, AppTheme.TextoPrincipal, AppTheme.FondoPrincipal);

        private static void AplicarEstiloBoton(Button boton, Color fondo, Color texto, Color hover)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = fondo;
            boton.ForeColor = texto;
            boton.Font = AppTheme.FuenteBoton;
            boton.Cursor = Cursors.Hand;
            boton.Height = AppTheme.AlturaBoton;
            boton.MinimumSize = new Size(AppTheme.AnchoBoton, AppTheme.AlturaBoton);
            boton.Padding = new Padding(12, 0, 12, 0);
            boton.FlatAppearance.MouseOverBackColor = hover;
            boton.UseVisualStyleBackColor = false;
        }

        public static void EstilizarTextBox(TextBox textBox)
        {
            textBox.Font = AppTheme.FuenteInput;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = AppTheme.Blanco;
            textBox.ForeColor = AppTheme.TextoPrincipal;
            textBox.Margin = new Padding(0, 4, 0, 4);
        }

        public static void EstilizarComboBox(ComboBox comboBox)
        {
            comboBox.Font = AppTheme.FuenteInput;
            comboBox.BackColor = AppTheme.Blanco;
            comboBox.ForeColor = AppTheme.TextoPrincipal;
            comboBox.FlatStyle = FlatStyle.Standard;
            comboBox.Margin = new Padding(0, 4, 0, 4);
        }

        public static void EstilizarLabel(Label label, bool esTitulo = false)
        {
            label.ForeColor = esTitulo ? AppTheme.TextoPrincipal : AppTheme.TextoSecundario;
            label.Font = esTitulo ? AppTheme.FuenteSubtitulo : AppTheme.FuenteNormal;
            label.BackColor = Color.Transparent;
        }

        public static void EstilizarGroupBox(GroupBox groupBox)
        {
            groupBox.ForeColor = AppTheme.AzulPrincipal;
            groupBox.Font = AppTheme.FuenteSubtitulo;
            groupBox.BackColor = AppTheme.Blanco;
            groupBox.Padding = new Padding(8, 4, 8, 8);
        }

        public static void EstilizarDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = AppTheme.Blanco;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = AppTheme.FondoSecundario;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = AppTheme.AzulPrincipal;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = AppTheme.Blanco;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(AppTheme.FuenteBoton, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = AppTheme.AzulPrincipal;
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.DefaultCellStyle.BackColor = AppTheme.Blanco;
            grid.DefaultCellStyle.ForeColor = AppTheme.TextoPrincipal;
            grid.DefaultCellStyle.Font = AppTheme.FuenteInput;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = AppTheme.TextoPrincipal;
            grid.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            grid.AlternatingRowsDefaultCellStyle.BackColor = AppTheme.FondoPrincipal;
            grid.RowTemplate.Height = 36;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void EstilizarTablaCotizacion(DataGridView grid)
        {
            EstilizarDataGridView(grid);
            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.RowTemplate.Height = 38;
            grid.ColumnHeadersHeight = 42;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static void EstilizarTextBoxesEn(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox textBox)
                    EstilizarTextBox(textBox);
                if (control.HasChildren)
                    EstilizarTextBoxesEn(control);
            }
        }

        public static void EstilizarComboBoxesEn(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is ComboBox comboBox)
                    EstilizarComboBox(comboBox);
                if (control.HasChildren)
                    EstilizarComboBoxesEn(control);
            }
        }

        public static void EstilizarLabelsEn(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is Label label)
                    EstilizarLabel(label, label.Font.Bold);
                if (control.HasChildren)
                    EstilizarLabelsEn(control);
            }
        }
    }
}
