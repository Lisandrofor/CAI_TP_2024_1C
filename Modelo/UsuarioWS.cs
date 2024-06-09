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


        //WS se usa para deserilizar
        //tiene todos los atributos de la response body del GET 

            public string id { get; set; }
            public string idUsuario { get; set; }
            public string host { get; set; }
            public string nombre;
            public string apellido;
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string email { get; set; }
            public DateTime? fechaNacimiento { get; set; }  // ? permite null
            public DateTime? FechaBaja { get; set; }  // ? permite null
            public string nombreUsuario;
            public int dni { get; set; }
            public string contraseña;

            public UsuarioWS(string idUsuario, string host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento,string nombreUsuario,string contraseña)
            {
                
                this.idUsuario = idUsuario;
                this.nombre = nombre;
                this.apellido = apellido;
                this.dni = dni;
                this.direccion = direccion;
                this.telefono = telefono;
                this.email = email;
                this.fechaNacimiento = fechaNacimiento;
                this.host = host;
                this.nombreUsuario = nombreUsuario;
                this.contraseña = contraseña;

             }

            public override string ToString()
            {
                return idUsuario + " " + nombre + " " + apellido;
            }
     }
 }
