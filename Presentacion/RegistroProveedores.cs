using Modelo;
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
    public partial class RegistroProveedores : Form
    {

        private List<Proveedor> proveedores = new List<Proveedor>();

        public RegistroProveedores()
        {
            InitializeComponent();
            
        }

        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProveedores();
            formulario.Show();
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            DateTime fechaingreso = DateTime.Now;
            long CUITIngreso = Convert.ToInt64(tbCUIT.Text);


            Proveedor proveedor = new Proveedor(tbNombre.Text, tbApellido.Text, fechaingreso, tbEmail.Text, CUITIngreso);

            proveedores.Add(proveedor);
            
            this.Hide();            
            Form formulario = new GestionProveedores();
            formulario.Show();
            
        }
    }
}
