using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using DAL;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Designproject> Designprojects { get; set; }
        public DbSet<Jobtitle> Jobtitles { get; set; }
        public DbSet<Orderforobject> Orderforobjects { get; set; }
        public DbSet<OrderLine> OredrLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Typeofwork> Typeofworks { get; set; }
        public DbSet<Workcatalog> Workcatalogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("jsconfig1.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Typeofwork>().HasKey(u => new { u.Order_number, u.Job_line_number });
            modelBuilder.Entity<OrderLine>().HasKey(u => new { u.Order_number, u.Order_line_number });
        }
    }
}

