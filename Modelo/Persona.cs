using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Persona
    {
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public DateTime _fechaAlta { get; set; }
        public DateTime? _fechaBaja { get; set; }
        public string _email { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaAlta, string email)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaAlta = fechaAlta;
            _email = email;
        }


    }
}
