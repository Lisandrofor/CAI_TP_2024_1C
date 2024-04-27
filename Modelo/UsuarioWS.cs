using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioWS
    {

        public string Id { get; set; }
        public string idUsuario { get; set; }
        public int host { get; set; }
        public string nombre;
        public string apellido;
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime? fechaNacimiento { get; set; }  
        public DateTime? FechaBaja { get; set; }  
        public string nombreUsuario;
        public int dni { get; set; }
        public string contraseña;

        public UsuarioWS()
        {

        } 
    }
}
