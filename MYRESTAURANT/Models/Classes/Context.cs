using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MYRESTAURANT.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillPoint> BillPoints { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}