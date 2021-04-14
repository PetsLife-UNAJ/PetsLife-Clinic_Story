using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public class TemplateDbContext:DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

       //AÑADIR DBSET
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
    }
}
