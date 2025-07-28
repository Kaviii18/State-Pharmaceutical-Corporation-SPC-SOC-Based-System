using SupplierManagemenet.Data;
using SupplierManagemenet.Models;
using System.Collections.Generic;
using System.Linq;

namespace SupplierManagemenet.Controllers
{
    public class InventoryController
    {
        // Get all inventory items with item name and supplier name (using navigation properties)
        public List<Inventory> GetInventoryItems()
        {
            using (var db = new SupplierDbContext())
            {
                // Eager load SupplierItem and Supplier
                return db.Inventories
                         .Include("SupplierItem.Supplier")
                         .ToList();
            }
        }

        // Update inventory when an order is confirmed
        public void UpdateInventory(int supplierItemId, int quantity)
        {
            using (var db = new SupplierDbContext())
            {
                var inventory = db.Inventories.FirstOrDefault(i => i.SupItemId == supplierItemId);
                if (inventory != null)
                {
                    inventory.Quantity += quantity;
                }
                else
                {
                    db.Inventories.Add(new Inventory
                    {
                        SupItemId = supplierItemId,
                        Quantity = quantity
                    });
                }
                db.SaveChanges();
            }
        }

        // Update Inventory Quantity (increment)
        public int UpdateInventoryQuantity(int supplierItemId, int quantity)
        {
            using (var db = new SupplierDbContext())
            {
                var inventory = db.Inventories.FirstOrDefault(i => i.SupItemId == supplierItemId);
                if (inventory != null)
                {
                    inventory.Quantity += quantity;
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }

        // Get Inventory for Plant Staff (Only SPC Items: supItemId == 1)
        public List<Inventory> GetPlantInventory()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Inventories
                         .Where(i => i.SupItemId == 1)
                         .ToList();
            }
        }

        // Get Inventory for Warehouse Staff (Excluding SPC Items: supItemId != 1)
        public List<Inventory> GetWarehouseInventory()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Inventories
                         .Where(i => i.SupItemId != 1)
                         .ToList();
            }
        }
    }
}
