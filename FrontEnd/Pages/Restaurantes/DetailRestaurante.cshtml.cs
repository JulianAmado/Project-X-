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
    public class DetailRestauranteModel : PageModel
    {
        private readonly IRepositorioRestaurante repositorioRestaurante;
        public Restaurante Restaurante { get; set; }

        public DetailRestauranteModel(IRepositorioRestaurante repositorioRestaurante)
        {
            this.repositorioRestaurante = repositorioRestaurante;
        }
        public IActionResult OnGet(int restauranteId)
        {
            Restaurante = repositorioRestaurante.GetRestaurante(restauranteId);
            if (Restaurante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
