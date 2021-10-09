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
    public class AddRestaurantesModel : PageModel
    {
        private readonly IRepositorioRestaurante repositorioRestaurante;
        public Restaurante RestauranteNuevo { get; set; }
        public AddRestaurantesModel(IRepositorioRestaurante repositorioRestaurante)
        {
            this.repositorioRestaurante = repositorioRestaurante;
        }
        public void OnGet()
        {
            RestauranteNuevo = new Restaurante();
        }

        public IActionResult OnPost(Restaurante RestauranteNuevo)
        {
            try
            {
                repositorioRestaurante.addRestaurante(RestauranteNuevo);
                return RedirectToPage("./ListRestaurantes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
