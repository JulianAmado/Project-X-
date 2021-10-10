using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace
{
    public class DetailClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }

        public DetailClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public IActionResult OnGet(int clienteId)
        {
            cliente = repositorioCliente.GetCliente(clienteId);
            if (cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
