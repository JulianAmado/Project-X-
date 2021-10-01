using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;

namespace Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEmpleado repoEmpleado;
        public Empleado empleado { get; set; }
        public DetailsModel(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repoEmpleado = repositorioEmpleado;
        }
        public IActionResult OnGet(int empleadoId) 
        {
            empleado = repoEmpleado.GetEmpleado(empleadoId);
            if (empleado == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
