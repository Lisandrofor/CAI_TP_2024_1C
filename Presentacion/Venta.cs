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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void lblTituloMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new MenuPrincipalVendedor();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new MenuPrincipalVendedor();
            formulario.Show();
        }
    }
}
