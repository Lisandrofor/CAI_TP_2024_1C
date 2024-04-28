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
    public partial class ReporteProductoMasVendidoPorCategoria : Form
    {
        public ReporteProductoMasVendidoPorCategoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReportesAdmSup();
            formulario.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }
    }
}
