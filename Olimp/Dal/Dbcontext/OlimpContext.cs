using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Olimp.Dal.Dbcontext
{


    public class OlimpFullLinePricesContext : DbContext
    {
        public DbSet<OlimpPrices> Prices { get; set; }

        public OlimpFullLinePricesContext()
        {


            Database.EnsureCreated();




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=ADMINRG-7G5H33A;Database=OlimpTestFull;Trusted_Connection=True;");
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



    public class OlimpPricesContext : DbContext
    {
        public DbSet<OlimpPrices> Prices { get; set; }

        public OlimpPricesContext()
        {


            Database.EnsureCreated();




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=ADMINRG-7G5H33A;Database=OlimpTest;Trusted_Connection=True;");
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


   
    


        





       
   
      
       
      
       
    
      
     
       
     
    




    


   
