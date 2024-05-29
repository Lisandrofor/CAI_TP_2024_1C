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
       string email, string idUsuarioActual, string nombreUsuario, string contraseña, DateTime fechaNacimiento)
        {

            // Crear un objeto usuarioWS
            var nuevoUsuarioWS = new UsuarioWS
            {

                idUsuario = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
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
