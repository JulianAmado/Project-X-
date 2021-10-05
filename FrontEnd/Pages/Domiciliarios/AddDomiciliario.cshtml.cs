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
    public class AddDomiciliarioModel : PageModel
    {
        private readonly IRepositorioDomiciliario repositorioDomiciliario;
        public Domiciliario domiciliarioNuevo { get; set; }
        
        public AddDomiciliarioModel(IRepositorioDomiciliario repositorioDomiciliario){
            this.repositorioDomiciliario=repositorioDomiciliario;
        }
        public void OnGet()
        {
            domiciliarioNuevo= new Domiciliario();
        }

        public IActionResult OnPost(Domiciliario domiciliarioNuevo ){
            try{
                repositorioDomiciliario.addDomiciliario(domiciliarioNuevo);
                return RedirectToPage("./ListDomiciliarios");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
