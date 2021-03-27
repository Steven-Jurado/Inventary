using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        //Como se llama la tabla
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<WareHousesEntity> WareHouses { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=.; Database=InventoryDb; trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "ASH1", CategoryName = "Carro" },
                new CategoryEntity { CategoryId = "ASH2", CategoryName = "Moto" },
                new CategoryEntity { CategoryId = "ASH3", CategoryName = "Computadora" }
                );

            modelBuilder.Entity<WareHousesEntity>().HasData(
                new WareHousesEntity { WareHousesId = Guid.NewGuid().ToString(), WareHousesName = "Central", WareHousesAddress = "Duran" },
                new WareHousesEntity { WareHousesId = Guid.NewGuid().ToString(), WareHousesName = "Central", WareHousesAddress = "Guayas" },
                new WareHousesEntity { WareHousesId = Guid.NewGuid().ToString(), WareHousesName = "Central", WareHousesAddress = "Puntilla" }
                );


        }

    }
}
