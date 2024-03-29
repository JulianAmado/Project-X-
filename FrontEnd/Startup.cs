using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistencia;

namespace FrontEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddSingleton<IRepositorioPersona>(new RepositorioPersona(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioEmpleado>(new RepositorioEmpleado(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioCliente>(new RepositorioCliente(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioDomiciliario>(new RepositorioDomiciliario(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioRestaurante>(new RepositorioRestaurante(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioPedido>(new RepositorioPedido(new Persistencia.ApplicationDbContext()));
            services.AddSingleton<IRepositorioProducto>(new RepositorioProducto(new Persistencia.ApplicationDbContext()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller = Conference}/{action = Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
