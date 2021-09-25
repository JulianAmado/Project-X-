using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente addCliente(Cliente cliente);
        Cliente updateCliente(Cliente cliente);
        IEnumerable<Cliente> getAllCliente();
        void deleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);
    }
}