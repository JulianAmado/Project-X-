using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages
{
    public class DeleteProductoModel : PageModel
    {
       
        
        private readonly IRepositorioProducto repositorioProducto;
        public Producto Producto { get; set; }

        public DeleteProductoModel(IRepositorioProducto repositorioProducto)
        {
            this.repositorioProducto = repositorioProducto;
        }


        public void OnGet(int productoId)
        {
            Producto = repositorioProducto.GetProducto(productoId);
        }

        public IActionResult OnPost(int productoId)
        {
            try
            {
                repositorioProducto.deleteProducto(productoId);
                return RedirectToPage("./Productos");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
        }
    }

