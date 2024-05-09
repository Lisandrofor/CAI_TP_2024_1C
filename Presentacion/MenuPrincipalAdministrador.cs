
namespace Presentacion
{
    public partial class MenuPrincipalAdministrador : Form
    {
        public MenuPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProductos();
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
