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
    public class ListDomiciliariosModel : PageModel
    {
        private readonly IRepositorioDomiciliario repositorioDomiciliario;
        [BindProperty(SupportsGet = true)]  //Para que sirve
        //esto es lo que va a obtener la lista de  domiciliario
        public IEnumerable<Domiciliario> Domiciliarios{get;set;}
        public string FiltroBusquedaDomiciliario {get; set; }

        //constructor que va a recibir lo que trae startup lo que trae los servicios

        public ListDomiciliariosModel(IRepositorioDomiciliario repositorioDomiciliario){
            this.repositorioDomiciliario=repositorioDomiciliario;
        }
        public void OnGet(string filtroBusqueda)
        {
            //Obtenemos todos los Domiciliarios  
            //Domiciliarios=repositorioDomiciliario.getAllDomiciliario();
            FiltroBusquedaDomiciliario = filtroBusqueda;
            Domiciliarios = repositorioDomiciliario.GetDomiciliariosPorFiltro(filtroBusqueda);
        }
    }
}
