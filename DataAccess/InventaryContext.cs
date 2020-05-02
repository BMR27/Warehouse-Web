﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database= InventoryDB; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName= "Aseo Hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumes" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId=  Guid.NewGuid().ToString(), WarehouseName="Bodega Central", WarehouseAddress="Calle los delfines con 23"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Sur", WarehouseAddress = "Calle 5 con 10" }


                );
        }
    }
}
