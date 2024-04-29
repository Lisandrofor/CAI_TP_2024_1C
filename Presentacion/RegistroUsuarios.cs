using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;


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

            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            int dni = int.Parse(tbDNI.Text);
            string direccion = tbDireccion.Text;
            string email = tbEmail.Text;
            string telefono = tbTelefono.Text;
            string categoria = comboBox1.Text;
            string nombreUsuario = tbUsuario.Text;
            string contraseña = tbContrasenia.Text;


            RegistroUsuario nuevoUsuario = new RegistroUsuario(nombre, apellido, dni, email, direccion, telefono, categoria, nombreUsuario, contraseña);

            Lista.AgregarUsuario(nuevoUsuario);

             Cargar.nuevacarga = new Cargar();
            nuevacarga.CargarPrivado(lista);
            BorrarCampos();
            MessageBox.Show($"Usuario Agregado Exitosamente");







            //this.Hide();
            //Form formulario = new GestionUsuarios();
            //formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form formulario = new GestionUsuarios();
            //formulario.Show();
        }


        private void BorrarCampos()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbDNI.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbUsuario.Clear();
            tbContrasenia.Clear();


        }

        mostrarUsuarios(Path);
    }
}
