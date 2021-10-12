using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
<<<<<<< HEAD
        private const String connectionString= @"Data Source= (localdb)\MSSQLLocalDB;Initial Catalog= DatabaseX ; Integrated Security=True";
=======

        private const String connectionString= @"Data Source= localhost\SQLEXPRESS;Initial Catalog= DatabaseX ; Integrated Security=True";
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379




        public DbSet <Persona> Personas {get;set;}
        public DbSet <Restaurante> Restaurantes {get;set;}
        public DbSet <Pedido> Pedidos {get;set;}
        public DbSet <Empresa> Empresas {get;set;}
        public DbSet <Empleado> Empleados {get;set;}
        public DbSet <Cliente> Clientes {get;set;}
        public DbSet <Domiciliario> Domiciliarios {get; set;}
        public DbSet <Producto> Productos {get; set;}
             


        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
        optionsBuilder.UseSqlServer(connectionString);

        }
    }
    }
}