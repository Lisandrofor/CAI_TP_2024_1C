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
    public partial class BajaProveedor : Form
    {
        public BajaProveedor()
        {
            InitializeComponent();
        }

        private void btnBajaProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new RegistroProveedores();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProveedores();
            formulario.Show();
        }
    }
}
