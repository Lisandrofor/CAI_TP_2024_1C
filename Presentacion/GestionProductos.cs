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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new RegistroProducto();
            formulario.Show();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ModificacionProducto();
            formulario.Show();
        }

        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new BajaProducto();
            formulario.Show();
        }
    }
}
