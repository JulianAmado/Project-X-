using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioDomiciliario : IRepositorioDomiciliario
    {

        private readonly ApplicationDbContext _appContext;

        public RepositorioDomiciliario(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        Cliente IRepositorioDomiciliario.addCDomiciliario(Domiciliario domiciliario)
        {
            var new_domiciliario = _appContext.Add(domiciliario);
            _appContext.SaveChanges();
            return new_domiciliario.Entity;
        }

        void IRepositorioDomiciliario.deleteDomiciliario(int idDomiciliario)
        {
            var DomiciliarioEncontrado = _appContext.Domiciliario.First(
               c => c.Id == idDomiciliario);

            if (DomiciliarioEncontrado == null)
            {
                return;
            }

            _appContext.Remove(DomiciliarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Domiciliario> IRepositorioDomiciliario.getAllDomiciliario()
        {
            return _appContext.Domiciliario;
        }

        Domiciliario IRepositorioDomiciliario.GetDomiciliario(int idDomiciliario)
        {
            return _appContext.Domiciliario.FirstOrDefault(
                c => c.Id == idDomiciliario
            );

        }

        Domiciliario IRepositorioDomiciliario.updateDomiciliarioe(Domiciliario domiciliario)
        {
            var DomiciliarioEncontrado = _appContext.Domiciliario.FirstOrDefault(
                c => c.Id == domiciliario.Id
            );
            if (DomiciliarioEncontrado != null)
            {
                DomiciliarioEncontrado.Nombre = domiciliario.Nombre;
                DomiciliarioEncontrado.Edad = domiciliario.Edad;
                DomiciliarioEncontrado.Documento = domiciliario.Documento;
                DomiciliarioEncontrado.Telefono = domiciliario.Telefono;
                DomiciliarioEncontrado.CorreoElectronico = domiciliario.CorreoElectronico;
                DomiciliarioEncontrado.Cargo = domiciliario.Cargo;
                DomiciliarioEncontrado.Horario = domiciliario.Horario;
                DomiciliarioEncontrado.Sueldo= domiciliario.Sueldo;
                DomiciliarioEncontrado.Transporte = domiciliario.Transporte;
               

                _appContext.SaveChanges();
            }

            return ClienteEncontrado;
        }
    }
}