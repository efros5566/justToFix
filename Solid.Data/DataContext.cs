using Microsoft.EntityFrameworkCore;
using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Recepies> recepies { get; set; }
        
        public DbSet<ProductsForRecepies> productsForRecepies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=receipes_db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsForRecepies>().HasKey(pr => new { pr.ProductsId, pr.RecepiesId });
        }

    }
}
