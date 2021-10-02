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
    public class ListModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        [BindProperty(SupportsGet = true)]  //Para que sirve
        
        public IEnumerable<Empleado> Empleados { get; set; }
        public string FiltroBusqueda {get; set; }
        
        public ListModel(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repositorioEmpleado = repositorioEmpleado;
        }
        public void OnGet(string filtroBusqueda) 
        {
            //Empleados = repositorioEmpleado.getAllEmpleado();
            FiltroBusqueda = filtroBusqueda;
            Empleados = repositorioEmpleado.GetEmpleadosPorFiltro(filtroBusqueda);
        }
    }
}
