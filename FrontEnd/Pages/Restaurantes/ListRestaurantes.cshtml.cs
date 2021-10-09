using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;

namespace FrontEnd.Pages
{
    public class ListRestaurantesModel : PageModel
    {
        private readonly IRepositorioRestaurante repositorioRestaurante;
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Restaurante> Restaurantes { get; set; }
        public string FiltroBusquedaRestaurante { get; set; }

        public ListRestaurantesModel(IRepositorioRestaurante repositorioRestaurante)
        {
            this.repositorioRestaurante = repositorioRestaurante;
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusquedaRestaurante = filtroBusqueda;
            Restaurantes = repositorioRestaurante.GetRestaurantesPorFiltro(filtroBusqueda);
        }
    }
}
