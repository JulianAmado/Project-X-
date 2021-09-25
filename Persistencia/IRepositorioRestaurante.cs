using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioRestaurante
    {
        Restaurante addRestaurante(Restaurante restaurante);
        Restaurante updateRestaurante(Restaurante restaurante);
        IEnumerable<Restaurante> getAllRestaurante();
        void deleteRestaurante(int idRestaurante);
        Restaurante GetRestaurante(int idRestaurante);
    }
}