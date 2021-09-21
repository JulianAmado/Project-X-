using System;

namespace Dominio
{
    public class Cliente : Persona
    {
        public int Id {get;set;}
        public String Direccion {get;set;}

        public String Forma_pago {get;set;}

    }
}