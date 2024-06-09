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

            string host="test";
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

            


            Usuario nuevoUsuario = new Usuario(host,idUsuario,nombre, apellido, dni, email, direccion, telefono, categoria, fechaNac, nombreUsuario, contraseña);
            GestorDeUsuarios gestorUsuario = new GestorDeUsuarios();
            GestordeUsuariosWS RegUsuario = new GestordeUsuariosWS();
            

            gestorUsuario.ValidarNombre(nombre);
            gestorUsuario.ValidarApellido(apellido);
            gestorUsuario.ValidarUsername(nombre, apellido, nombreUsuario);

            RegUsuario.AgregarUsuario(host,nombre,apellido, dni, direccion, telefono,
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







            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
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

        

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void tbCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
