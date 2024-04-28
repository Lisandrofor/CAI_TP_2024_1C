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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MenuPrincipalSupervisor menuSupervisor = new MenuPrincipalSupervisor();
        private MenuPrincipalAdministrador menuAdministrador = new MenuPrincipalAdministrador();
        private MenuPrincipalVendedor menuVendedor = new MenuPrincipalVendedor();
     

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            string usuarioActualTipo = tbName.Text;
            if (usuarioActualTipo == "v")
            {
                menuVendedor = new MenuPrincipalVendedor();
                menuVendedor.Show();
            }
            else if (usuarioActualTipo == "s")
            {
                menuSupervisor = new MenuPrincipalSupervisor();
                menuSupervisor.Show();
            }
            else if (usuarioActualTipo == "a")
            {
                menuAdministrador = new MenuPrincipalAdministrador();
                menuAdministrador.Show();
            }
           
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}
