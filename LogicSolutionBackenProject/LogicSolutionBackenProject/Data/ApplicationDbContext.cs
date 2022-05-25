using LogicSolutions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using LogicSolutionBackenProject.Models;

namespace LogicSolutions.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


            public DbSet<Flota> flotas { get; set; }
            public DbSet<Vehiculo> vehiculos { get; set; }
            public DbSet<Contacto> contactos { get; set; }
            public DbSet<Map> maps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
                .HasOne(v => v.Map)
                .WithOne(m => m.Vehiculo)
                .HasForeignKey<Map>(m => m.VehiculoId);
        }

    }
}
