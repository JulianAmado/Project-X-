using System.Collections;
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
    public class ListPedidoModel : PageModel
    {   
        private readonly IRepositorioPedido repositorioPedido;
        
        [BindProperty(SupportsGet =true)]
        public IEnumerable<Pedido> Pedidos {get;set;}

        public String filtroBusquedaPedido {get;set;}

        public ListPedidoModel (IRepositorioPedido repositorioPedido)
        {
            this.repositorioPedido= repositorioPedido;
        }

        public void OnGet(String filtroBusqueda)
        {
            filtroBusquedaPedido= filtroBusqueda;
            Pedidos= repositorioPedido.GetPedidoPorFiltro(filtroBusqueda);
            

        }
    }
}
