﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        // 6: Create DBContext(boiler plate code). Create options & connectionstring variables(boiler plate code).

        public DbSet<Person> Person { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        //public DbSet<County> County { get; set; }

        public ApplicationDbContext()
        {
            // en tom konstruktor behövs för att skapa migrations
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Denna behövs första gången man kör för att skapa databasen!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    }
}
