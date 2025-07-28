using SupplierManagemenet.Data;
using SupplierManagemenet.Models;
using System.Collections.Generic;
using System.Linq;

namespace SupplierManagemenet.Controllers
{
    public class SupplierController
    {
        // Insert new supplier
        public int InsertNewSupplier(Supplier supplier)
        {
            using (var db = new SupplierDbContext())
            {
                db.Suppliers.Add(supplier);
                return db.SaveChanges(); // Returns number of affected rows
            }
        }

        // Validate supplier login
        public Supplier ValidateSupplierLogin(string email, string password)
        {
            using (var db = new SupplierDbContext())
            {
                return db.Suppliers
                         .FirstOrDefault(s => s.SupplierEmail == email && s.SupplierPassword == password);
            }
        }

        // Get SPC Suppliers (supId = 1)
        public List<Supplier> GetSPCSuppliers()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Suppliers
                         .Where(s => s.SupplierId == 1)
                         .ToList();
            }
        }

        // Get Non-SPC Suppliers (supId != 1)
        public List<Supplier> GetNonSPCSuppliers()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Suppliers
                         .Where(s => s.SupplierId != 1)
                         .ToList();
            }
        }
    }
}
