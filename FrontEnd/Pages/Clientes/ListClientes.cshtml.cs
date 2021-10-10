using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class ListClientesModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        [BindProperty(SupportsGet = true)]  //Para que sirve
        //esto es lo que va a obtener la lista de  Cliente
        public IEnumerable<Cliente> Clientes{get;set;}
        public string FiltroBusquedaCliente {get; set; }

        //constructor que va a recibir lo que trae startup lo que trae los servicios

        public ListClientesModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente=repositorioCliente;
        }
        public void OnGet(string filtroBusqueda)
        {
            //Obtenemos todos los Clientes  
           // Clientes=repositorioCliente.getAllCliente();
            FiltroBusquedaCliente = filtroBusqueda;
            Clientes = repositorioCliente.GetClientesPorFiltro(filtroBusqueda);
        }
    }
}
