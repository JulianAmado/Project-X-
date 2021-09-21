using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioPersona
    {
         Persona addPersona (Persona persona);
         Persona updatePersona (Persona persona);
         
         IEnumerable <Persona> getAllPersona();
         void deletePersona (int idPersona);
         Persona GetPersona (int idPersona);

    }
}