using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
         Empleado addEmpleado (Empleado empleado);
         Empleado updateEmpleado (Empleado empleado);
         
         IEnumerable <Empleado> getAllEmpleado();
         void deleteEmpleado (int idEmpleado);
         Empleado GetEmpleado (int idEmpleado);
         IEnumerable<Empleado> GetEmpleadosPorFiltro(string filtro);

    }
}