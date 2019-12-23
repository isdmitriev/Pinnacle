using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PinnacleClasses.DatabaseObjects;
using System.Linq;
namespace PinnacleClasses.Datacontext
{
   public class PinnaclePricesContext:DbContext
    {
        public DbSet<PinacclePrices> Prices { get; set; }
        public PinnaclePricesContext()
        {
            

            Database.EnsureCreated();
            



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=ADMINRG-7G5H33A;Database=PinnaclePrices_current2;Trusted_Connection=True;");





        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.Relational().ColumnType = "decimal(18,7)";
            }


        }


    }
}
