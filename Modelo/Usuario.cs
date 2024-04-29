using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Modelo
{
    public abstract class Usuario
    {
        // Atributos privados
        public int host { get; set; }
        public string idUsuarioActual { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Categoria { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime? FechaNacimiento { get; set; }  // ? permite null
        public DateTime? FechaBaja { get; set; }  // ? permite null
        public string NombreUsuario { get; set; }
        public int DNI { get; set; }
        public string Contraseña { get; set; }
        private string nuevoPass;


        // Constructor



        public Usuario(string nombre,string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = GenerarPasswordTemporal();

        }




    

        // Propiedades
        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}

        //public string Apellido
        //{
        //    get { return apellido; }
        //    set { apellido = value; }
        //}

        //public string Username
        //{
        //    get { return username; }
        //    set
        //    {
        //        username = value;
        //    }
        //}

        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        password = value;
        //    }
        //}

        public string NuevoPass // nueva variable para la nueva pass
        {

            get { return nuevoPass; }
            set
            {
                nuevoPass = value;
            }
        }


        // Métodos
        //public void SetPassword(string newPassword)
        //{
        //    this.password = newPassword;
        //    this.ultimoCambioPass = DateTime.Now;
        //    this.intentosCambioPass = 0;

        //    // Si el usuario pone una nueva contraseña, lo marcamos como ACTIVO
        //    this.estado = EstadoUsuario.ACTIVO;
        //}


        public string GenerarPasswordTemporal()
        {
            return "Temp1234";

        }
        



       

        override public String ToString()
        {
            return this.Nombre + " - " + this.Apellido;
        }
    }

    public class RegistroUsuario:Usuario
        {
         public RegistroUsuario(string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña) : base(nombre,apellido,dni,email,direccion,telefono,categoria,nombreUsuario,contraseña)
            {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Categoria = categoria;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;


            }
        


        }

    public static class Lista
    {


        public static List<RegistroUsuario> listadeUsuarios = new List<RegistroUsuario>();

        public static void AgregarUsuario(RegistroUsuario nuevoUsuario)
        {
            listadeUsuarios.Add(nuevoUsuario);

            

        }

    }

    //StringBuilder mensaje = new StringBuilder();

    //    foreach (var RegistroUsuario in listadeUsuarios)
    //    {
    //        mensaje.AppendLine($"Nombre:RegistroUsuario.nombre)


    //    }








    public class Cargar
    {
        private void CargarUsuarios(List<RegistroUsuario> listadeUsuarios)
        {

            string docPath = @"C:\Users\pindy\Source\Repos\CAI_TP_2024_1C\BaseUsuarios.txt";




            using (StreamWriter registro = new StreamWriter(docPath, true))
            {
                foreach (RegistroUsuario registroUsuario in listadeUsuarios)
                    registro.WriteLine(registroUsuario.host+";"+registroUsuario.idUsuarioActual + ";" + registroUsuario.Nombre + ";" + registroUsuario.Apellido + ";" + registroUsuario.DNI + ";" + registroUsuario.Email + ";" + registroUsuario.Direccion + ";" + registroUsuario.Categoria + ";" + registroUsuario.NombreUsuario + ";" + registroUsuario.Contraseña);




            }


        }

        public void CargarPrivado()
        {

            CargarUsuarios();
        }

       



    }

       



       


    }











}
