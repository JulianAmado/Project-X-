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
    public class DeleteClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }
        public DeleteClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet(int clienteId)
        {
            cliente = repositorioCliente.GetCliente(clienteId);
        }

        public IActionResult OnPost(int clienteId)
        {
            repositorioCliente.deleteCliente(clienteId);
            return RedirectToPage("./ListClientes");
        }
    }
}
