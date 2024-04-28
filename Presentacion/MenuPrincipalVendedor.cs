using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipalVendedor : Form
    {
        public MenuPrincipalVendedor()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReportesVendedores();
            formulario.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Venta();
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Login();
            formulario.Show();
        }
    }
}
