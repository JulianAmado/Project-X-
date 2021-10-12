using System;

namespace Dominio
{
    public class Pedido
    {
        public int Id {get;set;}
        public String Factura {get;set;}
        public Producto Productos {get;set;}   
        public String Ubicacion {get;set;}
        public double Precio {get;set;}
        public String FormaPago {get;set;}
    }
}