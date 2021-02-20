using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapProjectContext : DbContext //Context nesnesi db tablolari ile proje classlarini iliskilendirir
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Northwind; Trusted_Connection=true");
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Colors> Colors{ get; set; }
        public DbSet<Brands> Brands { get; set; }
    }
        
}
