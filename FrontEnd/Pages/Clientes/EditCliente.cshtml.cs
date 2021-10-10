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
    public class EditClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }

        public EditClienteModel(IRepositorioCliente repositorioCliente)
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

        public IActionResult OnPost(Cliente cliente)
        {
            try
            {
                repositorioCliente.updateCliente(cliente);
                return RedirectToPage("./ListClientes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
