using System.Collections.Generic;
using Dominio;
using System.Linq;
using System;

namespace Persistencia
{
    public class RepositorioProducto : IRepositorioProducto
    {
       private readonly ApplicationDbContext _appContext;

        public RepositorioProducto(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        Producto IRepositorioProducto.addProducto(Producto producto)
        {
            var new_producto = _appContext.Add(producto);
            _appContext.SaveChanges();
            return new_producto.Entity;
        }

        void IRepositorioProducto.deleteProducto(int idproducto)
        {
            var ProductoEncontrado = _appContext.Productos.First(
               c => c.Id == idproducto);

            if (ProductoEncontrado == null)
            {
                return;
            }

            _appContext.Remove(ProductoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Producto> IRepositorioProducto.getAllProducto()
        {
            return _appContext.Productos;
        }

        Producto IRepositorioProducto.GetProducto(int idproducto)
        {
            return _appContext.Productos.FirstOrDefault(
                c => c.Id == idproducto
            );

        }

        //función para hacer el filtro por producto

         IEnumerable<Producto> IRepositorioProducto.GetProductoPorFiltro(string filtro)
        {
            IEnumerable<Producto> producto = _appContext.Productos;
            if (producto != null) 
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    producto = producto.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return producto;
        }

        Producto IRepositorioProducto.updateProducto(Producto producto)
        {
            var ProductoEncontrado = _appContext.Productos.FirstOrDefault(
                c => c.Id == producto.Id
            );
            if (ProductoEncontrado != null)
            {
                ProductoEncontrado.Id = producto.Id;
                ProductoEncontrado.Nombre = producto.Nombre;
                ProductoEncontrado.Cantidad = producto.Cantidad;
                ProductoEncontrado.Descripcion = producto.Descripcion;
                ProductoEncontrado.Descuento = producto.Descuento;
                ProductoEncontrado.PrecioFinal = producto.PrecioFinal;

                _appContext.SaveChanges();
            }

            return ProductoEncontrado;
        }
    }
}