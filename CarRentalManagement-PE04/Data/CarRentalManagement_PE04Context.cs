using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement_PE04.Domain;
using CarRentalManagement_PE04.Configurations.Entities;

namespace CarRentalManagement_PE04.Data
{
    public class CarRentalManagement_PE04Context : DbContext
    {
        public CarRentalManagement_PE04Context (DbContextOptions<CarRentalManagement_PE04Context> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement_PE04.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement_PE04.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement_PE04.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement_PE04.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement_PE04.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement_PE04.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new MakeSeed());
        }
    }
}
