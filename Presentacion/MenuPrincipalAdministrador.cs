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
    public partial class MenuPrincipalAdministrador : Form
    {
        public MenuPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void btnGestiondeUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionUsuarios();
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProductos();
            formulario.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnGestiondeProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProveedores();
            formulario.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Login();
            formulario.Show();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Login();
            formulario.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReportesAdmSup();
            formulario.Show();
        }
    }
}
