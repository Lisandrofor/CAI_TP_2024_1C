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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new MenuPrincipalSupervisor();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new MenuPrincipalSupervisor();
            formulario.Show();
        }
    }
}
