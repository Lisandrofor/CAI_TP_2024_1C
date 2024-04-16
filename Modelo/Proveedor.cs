using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Proveedor : Persona
    {
        
        public long _CUIT { get; set; }

        public Proveedor(string nombre, string apellido, DateTime fechaAlta, string email, long cuit)
            : base(nombre, apellido, fechaAlta, email)
        {
            _CUIT = cuit;
        }

       

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public string Email { get => _email; set => _email = value; }
        public long CUIT { get => _CUIT; set => _CUIT = value; }

        override
        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.CUIT + ")";
        }
    }
}
