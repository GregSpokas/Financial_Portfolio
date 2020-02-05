using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Financial_Portfolio.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Financial_Portfolio.DAL
{
    public class Stock_Context : DbContext
    {
        public Stock_Context() : base("Stock_Context")
        { 
        }
        public DbSet<Stock> Stock { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}