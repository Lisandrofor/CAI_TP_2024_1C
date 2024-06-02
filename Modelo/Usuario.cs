using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Modelo
{
    public class Usuario
    {
        // Atributos privados
        public Guid id { get; set; }

        public string idUsuario { get; set; }

        public string host { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }
        public string Categoria { get; set; }

        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime? fechaNacimiento { get; set; }  // ? permite null
        public DateTime? fechaBaja { get; set; }  // ? permite null
        public DateTime? fechaAlta { get; set; }
        public string nombreUsuario { get; set; }
        public int dni { get; set; }
        public string contraseña { get; set; }
        private string nuevoPass;



        public Usuario()
        { }


        // Constructor

        public Usuario(UsuarioWS usuarioWS)
        {

            this.host = usuarioWS.host;
            this.idUsuario = usuarioWS.id;
            this.nombre = usuarioWS.nombre;
            this.apellido = usuarioWS.apellido;
            this.dni = usuarioWS.dni;
            this.direccion = usuarioWS.direccion;
            this.telefono = usuarioWS.telefono;
            this.email = usuarioWS.email;
            this.fechaNacimiento = usuarioWS.fechaNacimiento;
            this.nombreUsuario = usuarioWS.nombreUsuario;
            this.contraseña = usuarioWS.contraseña;


        }

        public Usuario(string nombre,string apellido, int dni, string direccion,
            string telefono,string categoria, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            
            
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.Categoria = categoria;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;

        }










        public string NuevoPass // nueva variable para la nueva pass
        {

            get { return nuevoPass; }
            set
            {
                nuevoPass = value;
            }
        }










        override public String ToString()
        {
            return this.nombre + " - " + this.apellido;
        }



        //public Usuario(int host,string idusuarioactual, string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña, DateTime FechaNac)
        //{
        //    this.host = host;
        //    this.idUsuario = idusuarioactual;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.dni = dni;
        //    this.email = email;
        //    this.direccion = direccion;
        //    this.telefono = telefono;
        //    this.Categoria = categoria;
        //    this.nombreUsuario = nombreUsuario;
        //    this.contraseña = contraseña;
        //    this.fechaNacimiento = FechaNac;





        //}










    }


    public class Lista
    {


        public static  List<Usuario> listadeUsuarios = new List<Usuario>();

        public static void AgregarUsuario(Usuario nuevoUsuario)
        {
            listadeUsuarios.Add(nuevoUsuario);
            //CargarUsuarios(listadeUsuarios);



        }


        //private static void CargarUsuarios(List<RegistroUsuario> listadeUsuarios)
        //{

        //    string docPath =




        //    using (StreamWriter registro = new StreamWriter(docPath, true))
        //    {
        //        foreach (RegistroUsuario registroUsuario in listadeUsuarios)
        //            registro.WriteLine(registroUsuario.Host + ";" + registroUsuario.IdUsuarioActual + ";" + registroUsuario.Nombre + ";" + registroUsuario.Apellido + ";" + registroUsuario.DNI + ";" + registroUsuario.Email + ";" + registroUsuario.Direccion + ";" + registroUsuario.Categoria + ";" + registroUsuario.NombreUsuario + ";" + registroUsuario.Contraseña);




        //    }



        //}







    }















    
       

       



    

       



       


    }












