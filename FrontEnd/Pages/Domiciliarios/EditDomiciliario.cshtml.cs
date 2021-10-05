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
    public class EditDomiciliarioModel : PageModel
    {
        private readonly IRepositorioDomiciliario repositorioDomiciliario;
        public Domiciliario domiciliario { get; set; }

        public EditDomiciliarioModel(IRepositorioDomiciliario repositorioDomiciliario)
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

        public IActionResult OnPost(Domiciliario domiciliario){
            try{
                repositorioDomiciliario.updateDomiciliario(domiciliario);
                return RedirectToPage("./ListDomiciliarios");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
