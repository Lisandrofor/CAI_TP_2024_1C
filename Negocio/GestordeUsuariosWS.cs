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



        public bool AgregarUsuario( string nombre, string apellido, int dni, string direccion, string telefono,
        string email, DateTime fechaNac, string nombreUsuario, string contraseña)
        {

            // Crear un objeto usuarioWS
            var nuevoUsuarioWS = new UsuarioWS
            {

                idUsuario = "0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a",
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                direccion = direccion,
                telefono = telefono,
                email = email,
                nombreUsuario = nombreUsuario,
                contraseña = contraseña,
                fechaNacimiento = fechaNac,
                host = "test" //pasa segun opcion menu
            };

            try
            {
                UsuarioDatos.AgregarUsuario(nuevoUsuarioWS);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //public void AgregarUsuario(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario,string contraseña)
        //{

        //    UsuarioWS usuario = new UsuarioWS(idAdministrador, "test", nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
        //    UsuarioDatos.AgregarUsuario(usuario);

        //}



    }
}
