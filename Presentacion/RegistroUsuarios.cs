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

            int host=1;
            string idUsuario="";
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

            


            Usuario nuevoUsuario = new Usuario(host,idUsuario,nombre, apellido, dni, email, direccion, telefono, categoria, nombreUsuario, contraseña,fechaNac);
            GestorDeUsuarios gestorUsuario = new GestorDeUsuarios();
            GestordeUsuariosWS RegUsuario = new GestordeUsuariosWS();
            

            gestorUsuario.ValidarNombre(nombre);
            gestorUsuario.ValidarApellido(apellido);
            gestorUsuario.ValidarUsername(nombre, apellido, nombreUsuario);

            //bool response=RegUsuario.(1,"", dni, direccion, telefono,
            //            apellido, email,idUsuario,nombreUsuario,contraseña,fechaNac);

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
