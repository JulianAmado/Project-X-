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
    public class DeleteModel : PageModel
    {

        private readonly IRepositorioPedido repositorioPedido;
        public Pedido pedido {get; set;}
        public DeleteModel(IRepositorioPedido repositorioPedido)
        { this.repositorioPedido = repositorioPedido;
        }


        public void OnGet( int PedidoId)
        {
            pedido= repositorioPedido.GetPedido(PedidoId);
        }
        public IActionResult OnPost(int PedidoId){
            repositorioPedido.deletePedido(PedidoId);
            return RedirectToPage("./ListPedido");
        }
    }
}
