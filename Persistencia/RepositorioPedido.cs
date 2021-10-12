using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioPedido : IRepositorioPedido
    {

        private readonly ApplicationDbContext _appContext;
        public RepositorioPedido(ApplicationDbContext appContext){
            _appContext = appContext;
        }

        Pedido IRepositorioPedido.addPedido(Pedido pedido)
        {
            var new_pedido= _appContext.Pedidos.Add(pedido);
            _appContext.SaveChanges();
            return new_pedido.Entity;
        }

        void IRepositorioPedido.deletePedido(int idPedido)
        {
            var PedidoEncontrada= _appContext.Pedidos.FirstOrDefault(
                p => p.Id == idPedido
            );
            if (PedidoEncontrada == null)
            {
                return ;
            }
            _appContext.Remove(PedidoEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Pedido> IRepositorioPedido.getAllPedido()
        {
            return _appContext.Pedidos;
        }

        Pedido IRepositorioPedido.GetPedido(int idPedido)
        {
            return _appContext.Pedidos.FirstOrDefault(
                p => p.Id == idPedido
            );
        }

        IEnumerable<Pedido> IRepositorioPedido.GetPedidoPorFiltro(string filtro)
        {
            IEnumerable<Pedido> pedidos = _appContext.Pedidos;
            if (pedidos != null) 
            {
                if (!String.IsNullOrEmpty(filtro)) 
                {
                    pedidos = pedidos.Where(p => p.Factura.Contains(filtro));
                }
            }
            return pedidos;
        }

        Pedido IRepositorioPedido.updatePedido(Pedido pedido)
        {
            var PedidoEncontrado = _appContext.Pedidos.FirstOrDefault(
                p => p.Id == pedido.Id
            );
            if (PedidoEncontrado != null)
            {
                PedidoEncontrado.Productos= pedido.Productos;
                PedidoEncontrado.Ubicacion= pedido.Ubicacion;
                PedidoEncontrado.FormaPago= pedido.FormaPago;
                _appContext.SaveChanges();
            }

            return PedidoEncontrado;
        }
    }
}
    // Atributos Pedido

//  public int Id {get;set;}
//         public String Factura {get;set;}
//         public Producto Productos {get;set;}   
//         public String Ubicacion {get;set;}
//         public double Precio {get;set;}
//         public String FormaPago {get;set;}