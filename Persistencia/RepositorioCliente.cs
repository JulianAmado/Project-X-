using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {

        private readonly ApplicationDbContext _appContext;

        public RepositorioCliente(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        Cliente IRepositorioCliente.addCliente(Cliente cliente)
        {
            var new_cliente = _appContext.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }

        void IRepositorioCliente.deleteCliente(int idCliente)
        {
            var ClienteEncontrado = _appContext.Clientes.First(
               c => c.Id == idCliente);

            if (ClienteEncontrado == null)
            {
                return;
            }

            _appContext.Remove(ClienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Cliente> IRepositorioCliente.getAllCliente()
        {
            return _appContext.Clientes;
        }

        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(
                c => c.Id == idCliente
            );

        }

        //función para hacer el filtro por Cliente
         IEnumerable<Cliente> IRepositorioCliente.GetClientesPorFiltro(string filtro)
        {
            IEnumerable<Cliente> clientes = _appContext.Clientes;
            if (clientes != null) 
            {
                if (!String.IsNullOrEmpty(filtro)) 
                {
                    clientes = clientes.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return clientes;
        }

        Cliente IRepositorioCliente.updateCliente(Cliente cliente)
        {
            var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(
                c => c.Id == cliente.Id
            );
            if (ClienteEncontrado != null)
            {
                ClienteEncontrado.Nombre = cliente.Nombre;
                ClienteEncontrado.Edad = cliente.Edad;
                ClienteEncontrado.Documento = cliente.Documento;
                ClienteEncontrado.Telefono = cliente.Telefono;
                ClienteEncontrado.CorreoElectronico = cliente.CorreoElectronico;
                ClienteEncontrado.Direccion = cliente.Direccion;
                ClienteEncontrado.Forma_pago = cliente.Forma_pago;

                _appContext.SaveChanges();
            }

            return ClienteEncontrado;
        }
    }
}




// ATRIBUTOS PERSONA

//  public String Nombre {get;set;}
//         public String Edad {get;set;}
//         public String Documento {get;set;}
//         public String Telefono {get;set;}
//         public String CorreoElectronico {get;set;}



// ATRIBUTOS CLIENTE
//      public int Id {get;set;}
// public String Direccion {get;set;}

// public String Forma_pago {get;set;}