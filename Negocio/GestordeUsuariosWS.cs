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
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        


        public bool AgregarUsuario(string nombre, int host, int dni, string direccion, string telefono, string apellido,
       string email, string idUsuarioActual, string nombreUsuario,string contraseña, DateTime fechaNacimiento)
        {

            // Crear un objeto usuarioWS
            var nuevoUsuarioWS = new UsuarioWS
            {

                idUsuario = "0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a",
                host = host,
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                direccion = direccion,
                telefono = telefono,
                email = email,
                fechaNacimiento = fechaNacimiento,
                nombreUsuario = nombreUsuario,
                contraseña = contraseña
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

    }
}
