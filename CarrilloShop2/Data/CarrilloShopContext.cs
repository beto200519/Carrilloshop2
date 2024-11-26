using CarrilloShop2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CarrilloShop2.Data
{
    public class CarrilloShopContext : DbContext
    {
        public CarrilloShopContext(DbContextOptions<CarrilloShopContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.CliCorreo); // Clave primaria
        }
    }
}