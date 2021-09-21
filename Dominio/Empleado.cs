using System;
namespace Dominio
{
    public class Empleado : Persona
    {

        public int Id {get;set;}
        public String Cargo {get;set;}
        public String Horario {get;set;}
        public Double Sueldo {get;set;}
    }
}