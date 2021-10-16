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
    public class AddPedidoModel : PageModel
    {

        private readonly IRepositorioPedido repositorioPedido;
        private readonly IRepositorioProducto repositorioProducto;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Producto> Productos { get; set; }
        public Pedido PedidoNuevo {get;set;}

        public AddPedidoModel(IRepositorioPedido repositorioPedido, IRepositorioProducto repositorioProducto){
            this.repositorioPedido=repositorioPedido;
            this.repositorioProducto=repositorioProducto;
        }

        public void OnGet()
        {
            PedidoNuevo = new Pedido();
            Productos = repositorioProducto.getAllProducto(); // Cambio realizado
        }
        public IActionResult OnPost (Pedido PedidoNuevo){
            try
            {
                 repositorioPedido.addPedido(PedidoNuevo);
                 return RedirectToPage("./LisPedido");
            }
            catch
            {
                return RedirectToPage ("../Error");
            }
        }
    }
}
