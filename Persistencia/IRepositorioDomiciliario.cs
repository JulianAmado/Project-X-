using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioDomiciliario
    {
        Domiciliario addDomiciliario(Domiciliario domiciliario);
        Domiciliario updateDomiciliario(Domiciliario domiciliario);
        IEnumerable<Domiciliario> getAllDomiciliario();
        void deleteDomiciliario(int idDomiciliario);
        Domiciliario GetDomiciliario(int idDomiciliario);
        IEnumerable<Domiciliario> GetDomiciliariosPorFiltro(string filtro);
    }
}