using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AltaProveedor
    {
        String _idProveedor;
        String _idProducto;
        string _nombre;
        String _apellido;
        String _email;
        long _CUIT;
        String _host;

        public AltaProveedor(string idProveedor, string idProducto, string nombre, string apellido, string email, long CUIT, string host)
        {
            _idProveedor = idProveedor;
            _idProducto = idProducto;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _CUIT = CUIT;
            _host = host;
        }

        public string IdUsuario { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public long CUIT { get => _CUIT; set => _CUIT = value; }
        public string Host { get => _host; set => _host = value; }
    }
}
