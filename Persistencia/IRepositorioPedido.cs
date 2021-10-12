using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioPedido
    {
        Pedido addPedido(Pedido cliente);
        Pedido updatePedido(Pedido cliente);
        IEnumerable<Pedido> getAllPedido();
        void deletePedido(int idPedido);
        Pedido GetPedido(int idPedido);
        IEnumerable<Pedido> GetPedidoPorFiltro(string filtro);
    }
}