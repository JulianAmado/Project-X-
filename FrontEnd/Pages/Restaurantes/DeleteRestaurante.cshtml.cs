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
    public class DeleteRestauranteModel : PageModel
    {
        private readonly IRepositorioRestaurante repositorioRestaurante;
        public Restaurante Restaurante { get; set; }

        public DeleteRestauranteModel(IRepositorioRestaurante repositorioRestaurante)
        {
            this.repositorioRestaurante = repositorioRestaurante;
        }

        public void OnGet(int restauranteId)
        {
            Restaurante = repositorioRestaurante.GetRestaurante(restauranteId);
        }

        public IActionResult OnPost(int restauranteId)
        {
            try
            {
                repositorioRestaurante.deleteRestaurante(restauranteId);
                return RedirectToPage("./ListRestaurantes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
