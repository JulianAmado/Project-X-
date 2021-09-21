using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly ApplicationDbContext _appContext;

        public RepositorioPersona(ApplicationDbContext appContext){
            _appContext = appContext;
        }

        Persona IRepositorioPersona.addPersona(Persona persona)
        {
            var new_persona= _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }

        void IRepositorioPersona.deletePersona(int idPersona)
        {
            var PersonaEncontrada= _appContext.Personas.FirstOrDefault(
                p => p.Id == idPersona
            );
            if (PersonaEncontrada == null)
            {
                return ;
            }
            _appContext.Remove(PersonaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.getAllPersona()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.Id == idPersona
            );
        }

        Persona IRepositorioPersona.updatePersona(Persona persona)
        {
            var PersonaEncontrada = _appContext.Personas.FirstOrDefault(
                p => p.Id == persona.Id
            );
            if (PersonaEncontrada != null)
            {
                PersonaEncontrada.Nombre= persona.Nombre;
                PersonaEncontrada.Edad= persona.Edad;
                PersonaEncontrada.Documento= persona.Documento;
                PersonaEncontrada.Telefono = persona.Telefono;
                PersonaEncontrada.CorreoElectronico = persona.CorreoElectronico;
                _appContext.SaveChanges();
            }

            return PersonaEncontrada;
        }
    }
}


