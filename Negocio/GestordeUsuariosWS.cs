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

        public void AgregarUsuario(int host,string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento,string nombreUsuario,string contraseña,string categoria,string idusuarioactual)
        {
            UsuarioWS usuario = new UsuarioWS(host,idusuarioactual,nombre,apellido,dni,email,direccion,telefono,nombreUsuario,contraseña,fechaNacimiento);
            UsuarioDatos.AgregarUsuario(usuario);

        }

    }
}
