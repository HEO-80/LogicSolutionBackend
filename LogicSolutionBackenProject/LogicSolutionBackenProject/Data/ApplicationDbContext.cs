using LogicSolutions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

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


    }
}
