using System.Collections.Generic;
using Dominio;
namespace Persistencia
{
    public interface IRepositorioProducto
    {
       Producto addProducto(Producto producto);
       Producto updateProducto(Producto producto);
       IEnumerable<Producto> getAllProducto();
       void deleteProducto(int idproducto);
       Producto GetProducto(int idproducto);
       IEnumerable<Producto> GetProductoPorFiltro(string filtro);   
    }
}