using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence {
    public class VegaDbContext : DbContext {
        public VegaDbContext (DbContextOptions<VegaDbContext> optins) : base (optins) { }
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet <Model> Models{get; set;}
        public DbSet <Make> Make{get; set;}
    }
}