using System.Globalization;
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
        private static IRepositorioRestaurante _RepoRestaurante = new RepositorioRestaurante(
            new Persistencia.ApplicationDbContext()
        );
        private static IRepositorioDomiciliario _RepoDomiciliario= new RepositorioDomiciliario(
            new Persistencia.ApplicationDbContext()
        );


        static void Main(string[] args)
        {
            Console.WriteLine("----------------- Bienvenido --------------------");
            //  addCliente();
            // updateCliente();
            // deletePersona(2);
            // getAllPersona();
            // getPersona(3);
            //addRestaurante();
            //GetRestaurante(1);
            //getAllRestaurante();
            //updateRestaurante();
            //deleteRestaurante(1);

        }

        public static void addCliente()
        {
            var cliente = new Cliente
            {

                Nombre = "Martha Quiñonez",
                Edad = "20",
                Documento = "24990050",
                Telefono = "3148952036",
                CorreoElectronico = "marthaq@unicauca.edu.co",
                Direccion = "cra 12F #32 A ",
                Forma_pago = "efectivo"

            };

            _RepoCliente.addCliente(cliente);
        }


        public static void updateCliente()
        {
            var cliente = new Cliente
            {
                Id = 4,
                Nombre = "Martha Quiñonez",
                Edad = "22",
                Documento = "190084154",
                Telefono = "3148952036",
                CorreoElectronico = "marthaq@unicauca.edu.co",
                Direccion = "cra 12F #32 A 71 B ",
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

        public static void addRestaurante()
        {
            var restaurante = new Restaurante
            {
                Nombre = "Cualquier restaurante",
                NIT = "2000 - 1565",
                Razon_Social = "Comidas XAX",
                Calificacion = 5,
                UbicacionEmpresa = "Calle 410 # 39 -9",
                TelefonoEmpresa = "312 784 9899 ",
                CorreoEmpresa = "Cualquierestaurante@corre.com",
                Menu = "Papas fritas, hamburguesas"
            };
            _RepoRestaurante.addRestaurante(restaurante);
        }

        public static void GetRestaurante(int idRestaurante)
        {
            var Restaurante = _RepoRestaurante.GetRestaurante(idRestaurante);

            if (Restaurante == null)
            {
                return;
            }

            Console.WriteLine(Restaurante.Nombre);
        }

        public static void getAllRestaurante()
        {
            var Restaurante = _RepoRestaurante.getAllRestaurante();
            foreach (var restaurante in Restaurante)
            {
                Console.WriteLine(restaurante.NIT);
            }
        }

        public static void updateRestaurante()
        {
            var restaurante = new Restaurante
            {
                Id = 1,
                Nombre = "Comidax deliciosax",
                NIT = "20015 - 15677",
                Razon_Social = "Comidax XAX",
                Calificacion = 10,
                UbicacionEmpresa = "Calle 410 # 39 -9",
                TelefonoEmpresa = "312 784 9899 ",
                CorreoEmpresa = "comidaxdelixiosas@corre.com",
                Menu = "Papas fritas, hamburguesas"
            };
            _RepoRestaurante.updateRestaurante(restaurante);
        }

        public static void deleteRestaurante(int idRestaurante){
            _RepoRestaurante.deleteRestaurante(idRestaurante);
        }

        
        //   DomiciliarioEncontrado.Nombre = domiciliario.Nombre;
        //   DomiciliarioEncontrado.Edad = domiciliario.Edad;
        //   DomiciliarioEncontrado.Documento = domiciliario.Documento;
        //   DomiciliarioEncontrado.Telefono = domiciliario.Telefono;
        //   DomiciliarioEncontrado.CorreoElectronico = domiciliario.CorreoElectronico;
        //   DomiciliarioEncontrado.Cargo = domiciliario.Cargo;
        //   DomiciliarioEncontrado.Horario = domiciliario.Horario;
        //   DomiciliarioEncontrado.Sueldo= domiciliario.Sueldo;
        //   DomiciliarioEncontrado.Transporte = domiciliario.Transporte;


           public static void addCDomiciliario()
        {
            var domiciliario = new Domiciliario
            {
               
                Nombre = "Martha Quiñonez",
                Edad = "22",
                Documento = "190084154",
                Telefono = "3148952036",
                CorreoElectronico = "marthaq@unicauca.edu.co",
                Cargo = "Domiciliario",
                Horario = "Diurno",
                Sueldo = 2000000,
                Transporte = "Carro"            
               

            };
            _RepoDomiciliario.addDomiciliario(domiciliario);
        }

        public static void GetDomiciliario(int idDomiciliario)
        {
            var Domiciliario = _RepoDomiciliario.GetDomiciliario(idDomiciliario);

            if (Domiciliario == null)
            {
                return;
            }

            Console.WriteLine(Domiciliario.Nombre);
        }

        public static void getAllDomiciliario()
        {
            var Domiciliario = _RepoDomiciliario.getAllDomiciliario();
            foreach (var domiciliario in Domiciliario)
            {
                Console.WriteLine(domiciliario.Nombre);
            }
        }

        public static void updateDomiciliario()
        {
            var domiciliario = new Domiciliario
            {
                  Nombre = "Andrés Quiñonez",
                Edad = "22",
                Documento = "190084154",
                Telefono = "3148952036",
                CorreoElectronico = "marthaq@unicauca.edu.co",
                Cargo = "Domiciliario",
                Horario = "Nocturno",
                Sueldo = 2000000,
                Transporte = "Moto"   
            };
            _RepoDomiciliario.updateDomiciliario(domiciliario);
        }

        public static void deleteDomiciliario(int idDomiciliario){
            _RepoDomiciliario.deleteDomiciliario(idDomiciliario);
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

// public String Direccion {get;set;}

// public String Forma_pago {get;set;}