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
    public class DetailModel : PageModel
    {
        private readonly IRepositorioPedido repositorioPedido;
        public Pedido Pedidos{get;set;}

        public DetailModel(IRepositorioPedido repositorioPedido){
            this.repositorioPedido = repositorioPedido;
        }

        
        public IActionResult OnGet( int PedidoId) 
        { 
            Pedidos= repositorioPedido.GetPedido(PedidoId);
            if (Pedidos == null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page(); 
        }
    }
}
