using AccessData;
using AccessData.Commands;
using AccessData.Queries;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Application.Services;
using Domain.Entities;
using Domain.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SqlKata.Compilers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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
            services.AddControllers().AddFluentValidation();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PetsLife", Version = "v1" });
            });

            //AUTH CONFIG
            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("SecretKey"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.FromMinutes(0)
                };
            });
            //FIN AUTH CONFIG

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
            services.AddTransient<IMascotaQueries, MascotaQueries>();
            services.AddTransient<IMascotaService, MascotaService>();
            services.AddTransient<IVeterinarioService, VeterinarioService>();
            services.AddTransient<ITurnoService, TurnoService>();
            services.AddTransient<ITurnoQueries, TurnoQueries>();
            services.AddTransient<ITratamientoService, TratamientoService>();

            services.AddTransient<IValidator<Cliente>, ClienteValidator>();
            services.AddTransient<IValidator<HistoriaClinica>, HistoriaClinicaValidator>();
            services.AddTransient<IValidator<Mascota>, MascotaValidator>();
            services.AddTransient<IValidator<Registro>, RegistroValidator>();
            services.AddTransient<IValidator<Turno>, TurnoValidator>();
            services.AddTransient<IValidator<Veterinario>, VeterinarioValidator>();

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

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}