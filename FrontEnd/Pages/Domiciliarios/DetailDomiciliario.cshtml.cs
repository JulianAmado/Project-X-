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
    public class DetailDomiciliarioModel : PageModel
    {
        private readonly IRepositorioDomiciliario repositorioDomiciliario;
        public Domiciliario domiciliario { get; set; }

        public DetailDomiciliarioModel(IRepositorioDomiciliario repositorioDomiciliario)
        {
            this.repositorioDomiciliario = repositorioDomiciliario;
        }
        public IActionResult OnGet(int domiciliarioId)
        {
            domiciliario = repositorioDomiciliario.GetDomiciliario(domiciliarioId);
            if (domiciliario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

    }
}
