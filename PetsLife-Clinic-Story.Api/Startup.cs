using AccessData;
using AccessData.Commands;
using AccessData.Queries;
using AccessData.Queries.Repository;
using Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SqlKata.Compilers;
using System.Data;
using System.Data.SqlClient;

namespace PetsLife
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PetsLife", Version = "v1" });
            });


            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


            // SqlKata
            services.AddTransient<Compiler, SqlServerCompiler>();
            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });


            //Injection dependences
            services.AddTransient<IGenericRepository, GenericRepository>();
            services.AddTransient<IHistoriaClinicaQueries, HistoriaClinicaQueries>();
            services.AddTransient<IHistoriaClinicaService, HistoriaClinicaService>();
            services.AddTransient<IRegistroService, RegistroService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IClienteQueries, ClienteQueries>();

            //Added CORS
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });



            //Agregar ConnectionString en appsettings.json
            var ConnectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionString));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PetsLife v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
