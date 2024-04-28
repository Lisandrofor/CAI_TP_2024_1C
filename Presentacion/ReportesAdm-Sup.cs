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
    public partial class ReportesAdmSup : Form
    {
        public ReportesAdmSup()
        {
            InitializeComponent();
        }

        private void lblReporteventasporvendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReporteStockCritico();
            formulario.Show();
        }

        private void btnReorteVentasPorVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReporteVentasPorVendedor();
            formulario.Show();
        }

        private void btnProductosmasvendidopoprcategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ReporteProductoMasVendidoPorCategoria();
            formulario.Show();
        }
    }
}
