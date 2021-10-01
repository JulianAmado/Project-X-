using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {

        private readonly ApplicationDbContext _appContext;
        public RepositorioEmpleado(ApplicationDbContext appContext){
            _appContext = appContext;
        }

        Empleado IRepositorioEmpleado.addEmpleado(Empleado empleado)
        {
            var new_empleado= _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return new_empleado.Entity;
        }

        void IRepositorioEmpleado.deleteEmpleado(int idEmpleado)
        {
            var EmpleadoEncontrada= _appContext.Empleados.FirstOrDefault(
                e => e.Id == idEmpleado
            );
            if (EmpleadoEncontrada == null)
            {
                return ;
            }
            _appContext.Remove(EmpleadoEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Empleado> IRepositorioEmpleado.getAllEmpleado()
        {
            return _appContext.Empleados;
        }

        Empleado IRepositorioEmpleado.GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(
                e => e.Id == idEmpleado
            );
        }

        Empleado IRepositorioEmpleado.updateEmpleado(Empleado empleado)
        {
            var EmpleadoEncontrada = _appContext.Empleados.FirstOrDefault(
                e => e.Id == empleado.Id
            );
            if (EmpleadoEncontrada != null)
            {
                EmpleadoEncontrada.Nombre= empleado.Nombre;
                EmpleadoEncontrada.Edad= empleado.Edad;
                EmpleadoEncontrada.Documento= empleado.Documento;
                EmpleadoEncontrada.Telefono = empleado.Telefono;
                EmpleadoEncontrada.CorreoElectronico = empleado.CorreoElectronico;
                EmpleadoEncontrada.Cargo = empleado.Cargo;
                EmpleadoEncontrada.Horario = empleado.Horario;
                EmpleadoEncontrada.Sueldo = empleado.Sueldo;
                _appContext.SaveChanges();
            }

            return EmpleadoEncontrada;
        }
    }
}