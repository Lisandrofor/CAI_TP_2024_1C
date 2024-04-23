﻿using System;
using AccesoDatos;
using Modelo;

namespace Negocio
{
    

    public class GestorDeProductos
    {
        private List<Producto> productos = new List<Producto>();


        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public bool AgregarProducto(int idCategoria, string idUsuarioActual, string idProveedor, string nombre,
            decimal precio, int stock)
        {

            
            var nuevoProductoWS = new ProductosWS
            {
                idCategoria = idCategoria,
                idUsuario = idUsuarioActual,
                idProveedor = idProveedor,
                nombre = nombre,
                precio = precio,
                stock = stock
            };

            try
            {
                ProductosDatos.AgregarProducto(nuevoProductoWS);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BajaProductos(string idProducto, string idUsuario)
        {
            try
            {
                ProductosDatos.BajaProducto(idProducto, idUsuario);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<Producto> TraerProductos()
        {
            return ProductosDatos.TraerProductos();
        }

        public List<Producto> ListaProductosPorCategoria(int categoria)
        {
            return ProductosDatos.ListarProductoCategoria(categoria);
        }

        public bool ReactivarProducto(string idReactivar, string idUsuarioActual)
        {
            try
            {
                ProductosDatos.ReactivarProducto(idReactivar, idUsuarioActual);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
                 



    }

}