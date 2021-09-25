using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioRestaurante : IRepositorioRestaurante
    {
        private readonly ApplicationDbContext _appContext;

        public RepositorioRestaurante ( ApplicationDbContext appContext){
            _appContext= appContext;
        }

        Restaurante IRepositorioRestaurante.addRestaurante(Restaurante restaurante)
        {
            var new_restaurante= _appContext.Add(restaurante);
            _appContext.SaveChanges();
            return new_restaurante.Entity;
        }

        void IRepositorioRestaurante.deleteRestaurante(int idRestaurante)
        {
            var RestauranteEncontrado = _appContext.Restaurantes.First(
               r => r.Id == idRestaurante);

            if (RestauranteEncontrado == null)
            {
                return;
            }

            _appContext.Remove(RestauranteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Restaurante> IRepositorioRestaurante.getAllRestaurante()
        {
            return _appContext.Restaurantes;
        }

        Restaurante IRepositorioRestaurante.GetRestaurante(int idRestaurante)
        {
            return _appContext.Restaurantes.FirstOrDefault(
                r => r.Id == idRestaurante
            );
        }

        Restaurante IRepositorioRestaurante.updateRestaurante(Restaurante restaurante)
        {
            var RestauranteEncontrado = _appContext.Restaurantes.FirstOrDefault(
                r => r.Id == restaurante.Id
            );
            if (RestauranteEncontrado != null)
            {
                RestauranteEncontrado.Nombre = restaurante.Nombre;
                RestauranteEncontrado.NIT = restaurante.NIT;
                RestauranteEncontrado.Razon_Social = restaurante.Razon_Social;
                RestauranteEncontrado.Calificacion = restaurante.Calificacion;
                RestauranteEncontrado.UbicacionEmpresa = restaurante.UbicacionEmpresa;
                RestauranteEncontrado.TelefonoEmpresa = restaurante.TelefonoEmpresa;
                RestauranteEncontrado.CorreoEmpresa = restaurante.CorreoEmpresa;
                RestauranteEncontrado.Menu = restaurante.Menu;

                _appContext.SaveChanges();
            }

            return RestauranteEncontrado;
        }
    }
}

