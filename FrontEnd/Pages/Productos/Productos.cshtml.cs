using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;

namespace FrontEnd.Pages
{
    public class ProductosModel : PageModel
    {
        private readonly IRepositorioProducto RepositorioProducto;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Producto> Productos { get; set; }
        public string FiltroBusquedaProducto { get; set; }

        public ProductosModel(IRepositorioProducto RepositorioProducto)
        {
            this.RepositorioProducto = RepositorioProducto;
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusquedaProducto = filtroBusqueda;
            Productos = RepositorioProducto.GetProductoPorFiltro(filtroBusqueda);
        }
    }
}
