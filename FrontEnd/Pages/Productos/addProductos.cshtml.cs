using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages
{
    public class addProductosModel : PageModel
    {
        
        private readonly IRepositorioProducto RepositorioProducto;
        public Producto productoNuevo { get; set; }

        public addProductosModel(IRepositorioProducto RepositorioProducto)
        {
            this.RepositorioProducto = RepositorioProducto;
        }
        public void OnGet()
        {
            productoNuevo = new Producto();
        }

        public IActionResult OnPost(Producto productoNuevo)
        {
            try
            {
                RepositorioProducto.addProducto(productoNuevo);
                return RedirectToPage("./Productos");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }

}

  

