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
using Negocio;
using Modelo;

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

            string usuarioIngresado = tbName.Text.ToLower();
            string contraseñaIngresada = tbContraseña.Text.ToLower();

            List<Usuario> usuarios = LeerUsuarios();

            bool usuarioEncontrado = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.NombreUsuario.ToLower() == usuarioIngresado && usuario.Contraseña.ToLower() == contraseñaIngresada)
                {
                    usuarioEncontrado = true;
                   
                    // Mostrar la pantalla correspondiente según la categoría
                    switch (usuario.Categoria.ToLower())
                    {
                        case "administrador":
                            // Mostrar pantalla de administrador
                            this.Hide();
                            Form formulario = new MenuPrincipalAdministrador();
                            formulario.Show();
                            break;
                        
                        case "vendedor":
                            // Mostrar pantalla de vendedor
                            this.Hide();
                            Form formulario1 = new MenuPrincipalVendedor();
                            formulario1.Show();
                            break;
                        case "supervisor":
                            // Mostrar pantalla de supervisor
                            this.Hide();
                            Form formulario2 = new MenuPrincipalSupervisor();
                            formulario2.Show();
                            break;
                        default:
                            // Mensaje de error si la categoría no es válida
                            MessageBox.Show("Categoría de usuario no válida.");
                            break;
                    }

                    break; // Salir del bucle una vez que se encuentra el usuario
                }
               
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }



        }
        private void MostrarPantallaAdministrador()
        {
            this.Hide();
            Form formulario = new MenuPrincipalAdministrador();
            formulario.Show();
        }

        
        private void MostrarPantallaVendedor()
        {
            this.Hide();
            Form formulario = new MenuPrincipalVendedor();
            formulario.Show();
        }

      
        private void MostrarPantallaSupervisor()
        {
            this.Hide();
            Form formulario = new MenuPrincipalSupervisor();
            formulario.Show();
        }
        private List<Usuario> LeerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\santi\Desktop\TP CAI\RAMA SANTI 1\BaseUsuarios.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datosUsuario = linea.Split(';');
                        if (datosUsuario.Length != 3)
                        {
                            // Manejar la línea con formato incorrecto (por ejemplo, registrar un error o ignorar la línea)
                            continue;
                        }

                        Usuario usuario = new Usuario();
                        usuario.NombreUsuario = datosUsuario[0]; // Acceso directo al usuario en el indice 0
                        usuario.Contraseña = datosUsuario[1]; // Acceso directo a la contraseña en el indice 1
                        usuario.Categoria = datosUsuario[2];
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de usuarios: " + ex.Message);
            }

            return usuarios;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}
