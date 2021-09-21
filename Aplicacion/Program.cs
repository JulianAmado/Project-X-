using System;
using Dominio;
using Persistencia;
namespace Aplicacion
{
    class Program
    {
        private static IRepositorioPersona _RepoPersona=
        new RepositorioPersona(
            new Persistencia.ApplicationDbContext()
        );


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // addPersona();
            // updatePersona();
            // deletePersona(2);
            // getAllPersona();
            getPersona(3);

        }

        public static void addPersona(){
            var persona = new Persona{

                Nombre= "Julian Amado",
                Edad= "17",
                Documento= "1099708101",
                Telefono = "3197283549",
                CorreoElectronico= "j.amado1002@gmail.com"

            };

            _RepoPersona.addPersona(persona);
        }


        public static void updatePersona(){
            var persona = new Persona{
                Id= 1,
                Nombre= "Andres Argoti",
                Edad= "17",
                Documento= "1099708100",
                Telefono = "3028318363",
                CorreoElectronico= "andresmauricioarg@hotmail.com",

                

            };

            _RepoPersona.updatePersona( persona);
        }

        public static void deletePersona(int idPersona){
            _RepoPersona.deletePersona(idPersona);
        }


        public static void getPersona (int idPersona){
            var Persona= _RepoPersona.GetPersona(idPersona);

            if (Persona == null)
            {
                return ;
            }

            Console.WriteLine(Persona.Nombre);
        }

        public static void getAllPersona(){
            var Persona = _RepoPersona.getAllPersona();
            foreach (var persona in Persona)
            {
                Console.WriteLine(persona.Nombre);
            }
        }



        
        
    }
}
