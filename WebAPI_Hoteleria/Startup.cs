using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebAPI_Hoteleria.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Hoteleria
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI_Hoteleria", Version = "v1" });
            });



            // recuperar la cadena de conexion
            string cadena = Configuration.GetConnectionString("cn1");

            services.AddDbContext<HOTELERIA_SQLContext>(
                    option => option.UseSqlServer(cadena)
                );
            //Agregar
            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //permitir que las aplicaciones de React accedan al servicio Web
            //Por medio de http://localhost:3000
            app.UseCors(
                opcion =>
                {
                    opcion.WithOrigins("http://localhost:3000");
                    opcion.AllowAnyHeader();
                    opcion.AllowAnyMethod();
                }
                );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI_Hoteleria v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
