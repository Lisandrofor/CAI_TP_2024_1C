using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Proveedor
    {

        public string _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string _email { get; set; }
        public string _cuit { get; set; }
        public DateTime _fechaAlta { get; set; }
        public DateTime? _fechaBaja { get; set; }


        public Proveedor()
        {
            // Constructor para la deserialización
        }

        public Proveedor(string id, string nombre, string apellido, string email, string cuit, DateTime fechaAlta, DateTime? fechaBaja)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
        }

        public Proveedor(ProveedoresWS proveedorWS)
        {
            this._id = proveedorWS.idUsuario;
            this._nombre = proveedorWS.nombre;
            this._apellido = proveedorWS.apellido;
            this._email = proveedorWS.email;
            this._cuit = proveedorWS.cuit;
        }

        public override string ToString()
        {
            return _cuit.PadRight(20) + " " + _nombre.PadRight(25) + " " + _apellido.PadRight(25) + "(" + _id + ")";
        }

    }
}
