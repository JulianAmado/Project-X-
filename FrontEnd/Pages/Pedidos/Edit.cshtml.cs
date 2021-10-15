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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPedido repositorioPedido;
        public Pedido Pedidos { get; set; }

        public EditModel (IRepositorioPedido repositorioPedido){

            this.repositorioPedido= repositorioPedido;
        }
        

        
        
        public IActionResult OnGet( int PedidoID)
        {
            Pedidos= repositorioPedido.GetPedido(PedidoID);
            if (Pedidos == null)
            {
                return RedirectToPage("./NotFound");
            }else 
            return Page();
        }

        public IActionResult OnPost(Pedido pedido){

            try
            {
                 repositorioPedido.updatePedido(pedido);
                 return RedirectToPage("./ListPedido");
            }
            catch   
            {
                return RedirectToPage("../Error");
                ;
            }
        }
    }
}
