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
    public class DeleteDomiciliarioModel : PageModel
    {
        private readonly IRepositorioDomiciliario repositorioDomiciliario;
        public Domiciliario domiciliario { get; set; }

        public DeleteDomiciliarioModel(IRepositorioDomiciliario repositorioDomiciliario){
            this.repositorioDomiciliario=repositorioDomiciliario;
        }


        public void OnGet(int domiciliarioId)
        {
            domiciliario=repositorioDomiciliario.GetDomiciliario(domiciliarioId);
        }

        public IActionResult OnPost(int domiciliarioId)
        {
            repositorioDomiciliario.deleteDomiciliario(domiciliarioId);
            return RedirectToPage("./ListDomiciliarios");
        }
    }
}
