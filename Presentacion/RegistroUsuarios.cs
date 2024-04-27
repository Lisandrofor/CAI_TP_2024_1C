using Modelo;
using System;
using Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;

namespace Presentacion
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.nombre = tbNombre.Text;
            unUsuario.apellido = tbApellido.Text;
            unUsuario.dni = tbDNI.Text;
            unUsuario.email = tbEmail.Text;
            unUsuario.direccion = tbDireccion.Text;
            unUsuario.telefono = tbTelefono.Text;
            unUsuario.categoria = tbCategoria.Text;
            unUsuario.nombreUsuario = tbUsuario.Text;
            unUsuario.contraseña = tbContrasenia.Text;
            // unUsuario.fechaNacimiento = tbFechaDeNacimiento;
            MessageBox.Show("Bienvenido " + unUsuario.nombreUsuario + ", te has registrado con exito.");
            this.Hide();
            Form formulario = new Login();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionUsuarios();
            formulario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
