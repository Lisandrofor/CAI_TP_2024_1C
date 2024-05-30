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
        
        private String idAdministrador = "3fa85f64-5717-4562-b3fc-2c963f66afa6";


        public bool AgregarUsuario(string nombre, int host, int dni, string direccion, string telefono, string apellido,
        string email, string idUsuarioActual, string nombreUsuario,string contraseña, DateTime fechaNacimiento)
        {

            // Crear un objeto usuarioWS
            var nuevoUsuarioWS = new UsuarioWS
            {
                idUsuario = idUsuarioActual,
                host = host, //pasa segun opcion menu
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
