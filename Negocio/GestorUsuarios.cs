using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public bool AgregarUsuario(string nombre, int host, int dni, string direccion, string telefono, string apellido,
      string email, string idUsuarioActual, string nombreUsuario, DateTime fechaNacimiento)
        {

            //// Crear un objeto usuarioWS
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
                contraseña = "Temp1234"
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
                 return false; 
            }








    }

   
    
}
