using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class GestorDeProveedores
    {
        public List<Proveedor> ListarProveedores()
        {
            return ProveedorService.ListarProveedores();
        }

        public bool AltaProveedor(string nombre, string apellido, string cuit, string email, string idUsuario)
        {

            
            var nuevoProveedorWS = new ProveedoresWS
            {
                idUsuario = idUsuario,
                nombre = nombre,
                apellido = apellido,
                email = email,
                cuit = cuit
            };

            try
            {
                ProveedorService.AgregarProveedor(nuevoProveedorWS);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarProveedor(string id, string idUsuarioActual, string nombre, string apellido, string email, string cuit)
        {
            try
            {
                ProveedorService.ModificarProveedor(id, idUsuarioActual, nombre, apellido, email, cuit);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public Proveedor BuscarProveedor(string id)
        {
            Proveedor proveedor = ObtenerProveedorPorId(id);

            return proveedor;

        }

        public Proveedor ObtenerProveedorPorId(string idProveedor)
        {
            List<Proveedor> listaProveedores = ProveedorService.ListarProveedores();

            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor._id == idProveedor)
                {
                    return proveedor; // Devuelve el proveedor encontrado
                }
            }

            return null;
        }




        public bool BajaProveedor(string idProveedor, string idUsuario)
        {
            try
            {
                ProveedorService.BajaProveedor(idProveedor, idUsuario);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
