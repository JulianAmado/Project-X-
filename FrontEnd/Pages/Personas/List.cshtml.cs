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
    public class ListModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public IEnumerable<Persona> Personas { get; set; }
        public ListModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }
        public void OnGet()
        {
            Personas = repositorioPersona.getAllPersona();
        }
    }
}
