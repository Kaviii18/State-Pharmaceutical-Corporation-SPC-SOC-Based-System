using SupplierManagemenet.Models;
using System;
using System.Data.Entity;


namespace SupplierManagemenet.Data
{

    public class SupplierDbContext : DbContext
    {
        public SupplierDbContext() : base("DefaultConnection") { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<SupplierItem> SupplierItems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }


}
