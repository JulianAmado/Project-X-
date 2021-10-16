using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace Frontend.Pages
{
    [Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Empleado> Empleados { get; set; }
        public string FiltroBusqueda {get; set; }
        public ListModel(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repositorioEmpleado = repositorioEmpleado;
        }
        public void OnGet(string filtroBusqueda)
        {
            //Empleados = repositorioEmpleado.getAllEmpleado(); // Para obetenr todos los medicos
            FiltroBusqueda = filtroBusqueda;
            Empleados = repositorioEmpleado.GetEmpleadosPorFiltro(filtroBusqueda);
        }
    }
}
