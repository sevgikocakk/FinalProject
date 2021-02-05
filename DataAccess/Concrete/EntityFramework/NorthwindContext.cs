using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile classlarımızı ilişkinlendirğimiz sınıfdır.
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Hangi sunucuya ve oradaki hangi veritabanına bağlanacağımızı belirttik.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database=Nortwind;Trusted_Connection=true");
        }

     
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
