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
        private static IRepositorioEmpleado _RepoEmpleado= new RepositorioEmpleado(
            new Persistencia.ApplicationDbContext()
        );


        static void Main(string[] args)
        {
            Console.WriteLine("----------------- Bienvenido --------------------");
            //addCliente();
            //updateCliente();
            //deletePersona(2);
            //getAllPersona();
            //getPersona(3);
            //addRestaurante();
            //GetRestaurante(1);
            //getAllRestaurante();
            //updateRestaurante();
            //deleteRestaurante(1);
            //addDomiciliario();
            //GetDomiciliario(1);
            //getAllDomiciliario();
            //updateDomiciliario();
            //deleteDomiciliario(1);
            //addEmpleado();
            //GetEmpleado(1);
            //getAllEmpleado();
            updateEmpleado();
            //deleteEmpleado(1);
            //deleteEmpleado(2);
        }

        public static void addCliente()
        {
            var cliente = new Cliente
            {

                Nombre = "Andrés Argotti",
                Edad = "16",
                Documento = "251336",
                Telefono = "3310 1543 1554",
                CorreoElectronico = "AndresArgotti@bogota.edu.co",
                Direccion = "cra 12F #32 A ",
                Forma_pago = "Credito"

            };

            _RepoCliente.addCliente(cliente);
        }


        public static void updateCliente()
        {
            var cliente = new Cliente
            {
                Id = 3,
                Nombre = "Andrés Argoti",
                Edad = "17",
                Documento = "7449930132",
                Telefono = "621453013",
                CorreoElectronico = "andresmaurcioarg@gmail.com",
                Direccion = "Avenida siempre Viva 742 ",
                Forma_pago = "Crédito"

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


           public static void addDomiciliario()
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
                Id=1,
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
    

    public static void addEmpleado()
        {
            var empleado = new Empleado
            {

                Nombre = "Martha Quiñonez",
                Edad = "22",
                Documento = "190084154",
                Telefono = "3148952036",
                CorreoElectronico = "marthaq@unicauca.edu.co",
                Cargo = "Domiciliario",
                Horario = "Diurno",
                Sueldo = 2000000

            };

            _RepoEmpleado.addEmpleado(empleado);
        }


        public static void updateEmpleado()
        {
            var empleado = new Empleado
            {
                Id = 4,
                Nombre = "Julian Amado",
                Edad = "16",
                Documento = "997841365",
                Telefono = "300015423",
                CorreoElectronico = "j.amado1002@gmail.com",
                Cargo = "Ayudante de Chef",
                Horario = "Diurno",
                Sueldo = 1500000

            };

            _RepoEmpleado.updateEmpleado(empleado);
        }

        public static void GetEmpleado(int idEmpleado)
        {
            var Empleado = _RepoEmpleado.GetEmpleado(idEmpleado);

            if (Empleado == null)
            {
                return;
            }

            Console.WriteLine(Empleado.Nombre);
        }

        public static void getAllEmpleado()
        {
            var Empleado = _RepoEmpleado.getAllEmpleado();
            foreach (var empleado in Empleado)
            {
                Console.WriteLine(empleado.Nombre);
            }
        }
        public static void deleteEmpleado(int idEmpleado){
            _RepoEmpleado.deleteEmpleado(idEmpleado);
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