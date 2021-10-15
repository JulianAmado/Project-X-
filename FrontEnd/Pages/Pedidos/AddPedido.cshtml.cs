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
        private readonly IRepositorioProducto RepositorioProducto;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Producto> Productos { get; set; }
        
        public Pedido PedidoNuevo {get;set;}

        public AddPedidoModel(IRepositorioPedido repositorioPedido, IRepositorioProducto RepositorioProducto){
            this.repositorioPedido=repositorioPedido;
            this.RepositorioProducto=RepositorioProducto;

        }


        public void OnGet()
        {
            PedidoNuevo= new Pedido();
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
