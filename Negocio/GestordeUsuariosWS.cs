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




        public void AgregarUsuario(string nombre, int host, int dni, string direccion,string categoria, string telefono, string apellido,
       string email, string idUsuarioActual, string nombreUsuario, string contraseña, DateTime fechaNacimiento)
        {
            UsuarioWS registroUsuario = new UsuarioWS(idAdministrador, nombre, apellido, dni, direccion, telefono, email,categoria,nombreUsuario,contraseña,fechaNacimiento, "test");
            UsuarioDatos.AgregarUsuario(registroUsuario);

        }

    }
}
