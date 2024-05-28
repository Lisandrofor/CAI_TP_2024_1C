﻿using System;
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
        public Guid Id { get; set; }

        public string IdUsuario { get; set; }

        public int Host { get; set; }

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

        public Usuario(UsuarioWS usuarioWS)
        {

            this.Host = usuarioWS.host;
            this.IdUsuario = usuarioWS.Id;
            this.Nombre = usuarioWS.nombre;
            this.Apellido = usuarioWS.apellido;
            this.DNI = usuarioWS.dni;
            this.Direccion = usuarioWS.direccion;
            this.Telefono = usuarioWS.telefono;
            this.Email = usuarioWS.email;
            this.FechaNacimiento = usuarioWS.fechaNacimiento;
            this.NombreUsuario = usuarioWS.nombreUsuario;
            this.Contraseña = usuarioWS.contraseña;


        }



        //public Usuario(int host, string idusuarioactual, string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña, DateTime fechaNacimiento)
        //{
        //    this.Nombre = nombre;
        //    this.Apellido = apellido;
        //    this.NombreUsuario = nombreUsuario;
        //    this.Contraseña = GenerarPasswordTemporal();

        //}








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
            return this.Nombre + " - " + this.Apellido;
        }



        public Usuario(int host, string idusuarioactual, string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña, DateTime FechaNac) : base(host, idusuarioactual, nombre, apellido, dni, email, direccion, telefono, categoria, nombreUsuario, contraseña, FechaNac)
        {
            this.Host = host;
            this.IdUsuario = idusuarioactual;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Categoria = categoria;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.FechaNacimiento = FechaNac;





        }










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












