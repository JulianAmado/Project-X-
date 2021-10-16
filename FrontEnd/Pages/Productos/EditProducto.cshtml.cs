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
    public class EditProductoModel : PageModel
    {
        private readonly IRepositorioProducto repositorioProducto;
        public Producto Producto { get; set; }

        public EditProductoModel(IRepositorioProducto repositorioProducto)
        {
            this.repositorioProducto = repositorioProducto;
        }
        public IActionResult OnGet(int productoId)
        {
            Producto = repositorioProducto.GetProducto(productoId);
            if (Producto == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Producto producto)
        {
            try
            {
                repositorioProducto.updateProducto(producto);
                return RedirectToPage("./Productos");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
        }
    }

