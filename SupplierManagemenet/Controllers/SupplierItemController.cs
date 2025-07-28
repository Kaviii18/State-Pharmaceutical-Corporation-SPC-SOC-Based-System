using SupplierManagemenet.Data;
using SupplierManagemenet.Models;
using System.Collections.Generic;
using System.Linq;

namespace SupplierManagemenet.Controllers
{
    public class SupplierItemController
    {
        // Insert new SupplierItem
        public int InsertNewSupplierItem(SupplierItem item)
        {
            using (var db = new SupplierDbContext())
            {
                db.SupplierItems.Add(item);
                return db.SaveChanges(); // Returns number of rows affected (usually 1)
            }
        }

        // Get SPC Supplier Items (Only Supplier ID = 1)
        public List<SupplierItem> GetSPCOnlySupplierItems(int supplierId)
        {
            using (var db = new SupplierDbContext())
            {
                return db.SupplierItems
                         .Where(si => si.SupplierId == supplierId)
                         .ToList();
            }
        }

        // Get Non-SPC Supplier Items (All Suppliers Except ID = 1)
        public List<SupplierItem> GetNonSPCSupplierItems(int supplierId)
        {
            using (var db = new SupplierDbContext())
            {
                return db.SupplierItems
                         .Where(si => si.SupplierId != 1 && si.SupplierId == supplierId)
                         .ToList();
            }
        }
    }
}
