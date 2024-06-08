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
using Negocio;


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


            string idUsuarioActual = "0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a";
            string host="test"
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            int dni = int.Parse(tbDNI.Text);
            string direccion = tbDireccion.Text;
            string email = tbEmail.Text;
            string telefono = tbTelefono.Text;
            string categoria = comboBox1.Text;
            string nombreUsuario = tbUsuario.Text;
            string contraseña = tbContrasenia.Text;
            DateTime fechaNac = DateTime.Parse(TbFechaNac.Text);

            


            registroUsuarios nuevoUsuario = new registroUsuarios(nombre, apellido,dni,email, direccion, telefono, categoria, fechaNac, nombreUsuario, contraseña);
            GestorDeUsuarios gestorUsuario = new GestorDeUsuarios();
            GestordeUsuariosWS RegUsuario = new GestordeUsuariosWS();
            

            gestorUsuario.ValidarNombre(nombre);
            gestorUsuario.ValidarApellido(apellido);
            gestorUsuario.ValidarUsername(nombre, apellido, nombreUsuario);

            RegUsuario.AgregarUsuario(idUsuarioActual,host,nombre,apellido, dni, direccion, telefono,
                        email,fechaNac, nombreUsuario, contraseña);

          

            //if (!response)
            //{
            //    Console.WriteLine("Hubo un error al agregar el usuario supervisor. Por favor intente nuevamente.");
            //}
            //else
            //{
            //    Console.WriteLine("Usuario supervisor agregado con éxito.");
            //}



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
            TbFechaNac.Clear();


        }

        
    }
}
