using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClassLibraryNetCore.Model
{
    internal class ModelContext: DbContext
    {
        public DbSet<People> People { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EFCore2020;Trusted_Connection=True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany<Order>(o => o.Orders);

            modelBuilder.Entity<Order>()
                .HasOne<Customer>(od => od.Customer);

            modelBuilder.Entity<Artist>().HasMany<Album>(alb => alb.Albums);
            modelBuilder.Entity<Album>().HasMany<Artist>(art => art.Artists);
        }
    }
}