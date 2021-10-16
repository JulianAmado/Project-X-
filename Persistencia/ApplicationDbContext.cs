using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        private const String connectionString= @"Data Source= localhost\SQLEXPRESS;Initial Catalog= DatabaseX ; Integrated Security=True";

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