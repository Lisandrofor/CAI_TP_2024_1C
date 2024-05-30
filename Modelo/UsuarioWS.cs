using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioWS
    {
        private string _nombre, _apellido, _usuario, _direccion, _telefono, _email, _nombreUsuario, _contraseña, _categoria;
        private DateTime _fechaNacimiento;
        public string Id { get; set; }
        private int _host, _dni;
        public string idUsuario { get => idUsuario; set => idUsuario = value; }
        public int host { get => _host; set => _host = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }

        public string Categoria { get => _categoria; set => _categoria = value; }

        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string contraseña { get => _contraseña; set => _contraseña = value; }



        public UsuarioWS(string idusuarioactual, string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, string nombreUsuario, string contraseña, DateTime FechaNac, int host)
        {
            this.host = host;
            this.idUsuario = idusuarioactual;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.Categoria = categoria;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.fechaNacimiento = FechaNac;





        }





        public override string ToString()
        {
            return string.Format("{nombre} - {apellido}.");
        }
    }
}
