using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string contraseña;
        public string categoria;
        public string idUsuario;
        public string host;

        public string dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public string Id { get; set; }
        public DateTime? FechaBaja { get; set; }
        
        public Usuario()
        {
        }

        
    }
   
}
