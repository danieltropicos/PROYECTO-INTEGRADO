using Proyecto_Integrador.Vistas.Cotizaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Vistas.Layout
{
    public partial class HomeLayout : Form
    {
        public HomeLayout()
        {
            InitializeComponent();
        }

        private void AbrirVista(UserControl vista)
        {
            panelContenido.Controls.Clear();

            vista.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(vista);
        }

        //Boton Usuarios
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Boton Clientes
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Boton Cotizaciones
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirVista(new CotizacionControl());
        }

        //Boton Facturas
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
