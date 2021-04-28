using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AccessData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //AÑADIR DBSETs
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<CalendarioTurno> CalendarioTurno { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Consultorio> Consultorio { get; set; }
        public DbSet<Veterinaria> Veterinaria { get; set; }
    }
}
