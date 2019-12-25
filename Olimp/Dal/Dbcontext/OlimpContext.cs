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
using Olimp.Dal.NewdatabaseClasses;

namespace Olimp.Dal.Dbcontext
{


    public class OlimpPricesContext : DbContext
    {
        public DbSet<OlimpPrices> Prices { get; set; }

        public OlimpPricesContext()
        {


            Database.EnsureCreated();




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=ADMINRG-7G5H33A;Database=OlimpTesNewSchema;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.Relational().ColumnType = "decimal(18,4)";
            }


        }
    }

    public class OlimpPricesFullLineContext : DbContext
    {
        public DbSet<OlimpPrices> Prices { get; set; }

        public OlimpPricesFullLineContext()
        {


            Database.EnsureCreated();




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=ADMINRG-7G5H33A;Database=OlimpTesNewSchemaFullLine;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.Relational().ColumnType = "decimal(18,4)";
            }


        }
    }


}


    



   



   
    


        





       
   
      
       
      
       
    
      
     
       
     
    




    


   
