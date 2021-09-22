using System;
using Dominio;
using Persistencia;
namespace Aplicacion
{
    class Program
    {
        private static IRepositorioCliente _RepoCliente = new RepositorioCliente(
            new Persistencia.ApplicationDbContext()
        );


        static void Main(string[] args)
        {
            Console.WriteLine("----------------- Bienvenido --------------------");
            //  addCliente();
            updateCliente();
            // deletePersona(2);
            // getAllPersona();
            // getPersona(3);

        }

        public static void addCliente(){
            var cliente = new Cliente{

                Nombre= "Martha Quiñonez",
                Edad= "20",
                Documento= "24990050",
                Telefono = "3148952036",
                CorreoElectronico= "marthaq@unicauca.edu.co",
                Direccion= "cra 12F #32 A ",
                Forma_pago = "efectivo"

            };

            _RepoCliente.addCliente(cliente);
        }


        public static void updateCliente(){
            var cliente = new Cliente{
                Id= 4,
                Nombre= "Martha Quiñonez",
                Edad= "22",
                Documento= "190084154",
                Telefono = "3148952036",
                CorreoElectronico= "marthaq@unicauca.edu.co",
                Direccion= "cra 12F #32 A 71 B ",
                Forma_pago = "Debito/Credito"

            };

            _RepoCliente.updateCliente(cliente);
        }

        // public static void deletePersona(int idPersona){
        //     _RepoPersona.deletePersona(idPersona);
        // }


        // public static void getPersona (int idPersona){
        //     var Persona= _RepoPersona.GetPersona(idPersona);

        //     if (Persona == null)
        //     {
        //         return ;
        //     }

        //     Console.WriteLine(Persona.Nombre);
        // }

        // public static void getAllPersona(){
        //     var Persona = _RepoPersona.getAllPersona();
        //     foreach (var persona in Persona)
        //     {
        //         Console.WriteLine(persona.Nombre);
        //     }
        // }



        
        
    }
}


        // ATRIBUTOS PERSONA

//  public String Nombre {get;set;}
//         public String Edad {get;set;}
//         public String Documento {get;set;}
//         public String Telefono {get;set;}
//         public String CorreoElectronico {get;set;}



            // ATRIBUTOS CLIENTE
        
        // public String Direccion {get;set;}

        // public String Forma_pago {get;set;}