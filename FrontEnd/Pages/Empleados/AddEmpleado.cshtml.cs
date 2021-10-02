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
    public class AddEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        public Empleado empleadoNuevo { get; set; }
        public AddEmpleadoModel(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repositorioEmpleado = repositorioEmpleado;
        }
        public void OnGet()
        {
            empleadoNuevo = new Empleado();
        }
        public IActionResult OnPost(Empleado empleadoNuevo)
        {
            try{
                repositorioEmpleado.addEmpleado(empleadoNuevo);
                return RedirectToPage("./List");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
