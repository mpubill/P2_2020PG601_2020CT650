using Microsoft.EntityFrameworkCore;
namespace P2_2020PG601_2020CT650.Models
{
    public class covidDbContext:DbContext
    {
        public covidDbContext(DbContextOptions options) : base(options) { }

        public DbSet<genero> genero { get; set; }
        public DbSet<departamento> departamento { get; set; }
        public DbSet<casos_reportados> casos_reportados { get; set; }
    }
}
