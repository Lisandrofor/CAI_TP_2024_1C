using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesoadatos;
using Modelo;

namespace Negocio
{
    public class GestordeUsuariosWS
    {
        private UsuarioDatos UsuarioDatos = new UsuarioDatos();

        private String idUsuario = "3fa85f64-5717-4562-b3fc-2c963f66afa6";


        //public bool AgregarUsuario(string idUsuario,string nombre, int host, int dni, string direccion, string telefono, string apellido,
        //string email, string nombreUsuario,string contraseña, DateTime fechaNacimiento)
        //{

        //    // Crear un objeto usuarioWS
        //    var nuevoUsuarioWS = new UsuarioWS
        //    {
                
        //        idUsuario = idUsuario,
        //        nombre = nombre,
        //        apellido = apellido,
        //        dni = dni,
        //        direccion = direccion,
        //        telefono = telefono,
        //        email = email,
        //        nombreUsuario = nombreUsuario,
        //        contraseña = contraseña,
        //        fechaNacimiento = fechaNacimiento,
        //        host = host //pasa segun opcion menu
        //    };

        //    try
        //    {
        //        UsuarioDatos.AgregarUsuario(nuevoUsuarioWS);

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

                       
        public void AgregarUsuario(string host,string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario,string contraseña)
        {
            UsuarioWS RegistroWS = new UsuarioWS(idUsuario,host, nombre, apellido,dni, direccion, telefono, email,fechaNacimiento, nombreUsuario, contraseña);
            UsuarioDatos.AgregarUsuario(RegistroWS);

        }



    }
}
