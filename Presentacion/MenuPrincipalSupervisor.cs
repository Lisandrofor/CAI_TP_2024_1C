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
    public partial class MenuPrincipalSupervisor : Form
    {
        public MenuPrincipalSupervisor()
        {
            InitializeComponent();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProductos();
            formulario.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReportesAdmSup();
            formulario.Show();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Devolucion();
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
