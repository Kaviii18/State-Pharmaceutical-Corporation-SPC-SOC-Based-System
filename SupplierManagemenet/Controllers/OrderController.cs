using SupplierManagemenet.Data;
using SupplierManagemenet.Models;
using System.Collections.Generic;
using System.Linq;

namespace SupplierManagemenet.Controllers
{
    public class OrderController
    {
        // Insert new order 
        public int InsertNewOrder(Order order)
        {
            using (var db = new SupplierDbContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return order.OrderId; // OrderId is auto-populated after SaveChanges
            }
        }

        // Get Pending Orders for a Supplier
        public List<Order> GetPendingOrders(int supplierId)
        {
            using (var db = new SupplierDbContext())
            {
                return db.Orders
                    .Where(o => o.OrderStatus == "Pending" && o.SupplierId == supplierId)
                    .ToList();
            }
        }

        // Get "Priced" orders for SPC suppliers (supId = 1)
        public List<Order> GetSPCPricedOrders()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Orders
                    .Where(o => o.OrderStatus == "Priced" && o.SupplierId == 1)
                    .ToList();
            }
        }

        // Get "Priced" orders for non-SPC suppliers (supId != 1)
        public List<Order> GetNonSPCPricedOrders()
        {
            using (var db = new SupplierDbContext())
            {
                return db.Orders
                    .Where(o => o.OrderStatus == "Priced" && o.SupplierId != 1)
                    .ToList();
            }
        }

        // Update order price by supplier
        public int UpdateOrderPrice(int orderId, decimal unitPrice)
        {
            using (var db = new SupplierDbContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.UnitPrice = unitPrice;
                    return db.SaveChanges();
                }
                return 0;
            }
        }

        // Confirm order price
        public int ConfirmOrder(int orderId)
        {
            using (var db = new SupplierDbContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.OrderStatus = "Priced";
                    return db.SaveChanges();
                }
                return 0;
            }
        }

        // Confirm order and update inventory
        public int ConfirmOrderByStaff(int orderId)
        {
            using (var db = new SupplierDbContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.OrderStatus = "Confirmed";
                    db.SaveChanges();

                    // Update Inventory
                    var inventory = db.Inventories.FirstOrDefault(i => i.SupItemId == order.SupplierItemId);
                    if (inventory != null)
                    {
                        inventory.Quantity += order.Quantity;
                    }
                    else
                    {
                        db.Inventories.Add(new Inventory
                        {
                            SupItemId = order.SupplierItemId,
                            Quantity = order.Quantity
                        });
                    }
                    return db.SaveChanges();
                }
                return 0;
            }
        }
    }
}
