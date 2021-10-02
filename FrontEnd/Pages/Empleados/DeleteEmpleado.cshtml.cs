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
    public class DeleteEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repoEmpleado;
        public Empleado empleado { get; set; }
        public DeleteEmpleadoModel(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repoEmpleado = repositorioEmpleado;
        }   
        
        public void OnGet(int empleadoId)
        {
            empleado = repoEmpleado.GetEmpleado(empleadoId);
        }
        public IActionResult OnPost(int empleadoId)
        {
            repoEmpleado.deleteEmpleado(empleadoId);
            return RedirectToPage("./List");
        }
    }
}
