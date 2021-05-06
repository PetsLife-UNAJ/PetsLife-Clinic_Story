using AccessData.Configuration;
using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AccessData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<CalendarioTurno> CalendarioTurno { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Consultorio> Consultorio { get; set; }
        public DbSet<Veterinaria> Veterinaria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        public DbSet<Tratamiento> Tratamiento { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Model Contraints
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ClienteConfiguration(modelBuilder.Entity<Cliente>());
            new MascotaConfiguration(modelBuilder.Entity<Mascota>());
            new TurnoConfiguration(modelBuilder.Entity<Turno>());
            new VeterinarioConfiguration(modelBuilder.Entity<Veterinario>());
            new ConsultorioConfiguration(modelBuilder.Entity<Consultorio>());
            new VeterinariaConfiguration(modelBuilder.Entity<Veterinaria>());
            new HistoriaClinicaConfiguration(modelBuilder.Entity<HistoriaClinica>());
            new RegistroConfiguration(modelBuilder.Entity<Registro>());
            new CalendarioTurnoConfiguration(modelBuilder.Entity<CalendarioTurno>());
        }
    }
}