using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data.Entities;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicles.API.Data.Entities.Procedure> Procedures { get; set; }
        public DbSet<Vehicles.API.Data.Entities.VehicleType> VehicleType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
        }
    }
