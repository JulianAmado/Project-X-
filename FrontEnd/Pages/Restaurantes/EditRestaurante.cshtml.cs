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
    public class EditRestauranteModel : PageModel
    {
        private readonly IRepositorioRestaurante repositorioRestaurante;
        public Restaurante Restaurante { get; set; }

        public EditRestauranteModel(IRepositorioRestaurante repositorioRestaurante)
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

        public IActionResult OnPost(Restaurante Restaurante)
        {
            try
            {
                repositorioRestaurante.updateRestaurante(Restaurante);
                return RedirectToPage("./ListRestaurantes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
