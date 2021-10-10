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
    public class AddClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente clienteNuevo { get; set; }

        public AddClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet()
        {
            clienteNuevo = new Cliente();
        }

        public IActionResult OnPost(Cliente clienteNuevo)
        {
            try
            {
                repositorioCliente.addCliente(clienteNuevo);
                return RedirectToPage("./ListClientes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
