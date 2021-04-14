using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AccessData
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

        //AÑADIR DBSETs
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Registro> Registros { get; set; }
    }
}
