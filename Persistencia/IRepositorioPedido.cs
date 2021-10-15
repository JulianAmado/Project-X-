using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioPedido
    {
        Pedido addPedido(Pedido pedido);
        Pedido updatePedido(Pedido pedido);
        IEnumerable<Pedido> getAllPedido();
        void deletePedido(int idPedido);
        Pedido GetPedido(int idPedido);
        IEnumerable<Pedido> GetPedidoPorFiltro(string filtro);
    }
}