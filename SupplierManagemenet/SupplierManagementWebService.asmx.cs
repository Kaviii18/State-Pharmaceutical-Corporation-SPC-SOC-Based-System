using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SupplierManagemenet.Controllers;
using SupplierManagemenet.Models;

namespace SupplierManagemenet
{
    /// <summary>
    /// Summary description for SupplierManagementWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SupplierManagementWebService : System.Web.Services.WebService
    {
        // Web method to insert a new supplier
        [WebMethod]
        public int InsertSupplierWeb(string supplierName, string supplierContact, string supplierEmail, string supplierPassword)
        {
            Supplier s = new Supplier();
            s.SupplierName = supplierName;
            s.SupplierContact = supplierContact;
            s.SupplierEmail = supplierEmail;
            s.SupplierPassword = supplierPassword;
            return new SupplierController().InsertNewSupplier(s);
        }

        // Web method for supplier login
        [WebMethod]
        public Supplier LoginSupplierWeb(string email, string password)
        {
            return new SupplierController().ValidateSupplierLogin(email, password);
        }

        // Web method to get SPC suppliers
        [WebMethod]
        public List<Supplier> GetSPCSuppliersWeb()
        {
            return new SupplierController().GetSPCSuppliers();
        }

        // Web method to get non-SPC suppliers
        [WebMethod]
        public List<Supplier> GetNonSPCSuppliersWeb()
        {
            return new SupplierController().GetNonSPCSuppliers();
        }

        // Web method to insert new order
        [WebMethod]
        public int PlaceOrderWeb(int supplierId, string staffType, int supplierItemId, int quantity)
        {
            Order o = new Order();
            o.SupplierId = supplierId;
            o.StaffType = staffType;
            o.SupplierItemId = supplierItemId;
            o.Quantity = quantity;
            o.OrderStatus = "Pending";

            return new OrderController().InsertNewOrder(o);
        }

        // Web method to get pending orders for a supplier
        [WebMethod]
        public List<Order> GetSupplierOrdersWeb(int supplierId)
        {
            return new OrderController().GetPendingOrders(supplierId);
        }

        // Web method for suppliers to update order price
        [WebMethod]
        public int UpdateOrderPriceWeb(int orderId, decimal unitPrice)
        {
            return new OrderController().UpdateOrderPrice(orderId, unitPrice);
        }

        // Web method for staff to confirm the order
        [WebMethod]
        public int ConfirmOrderWeb(int orderId)
        {
            return new OrderController().ConfirmOrder(orderId);
        }

        // web method to get inventory items
        [WebMethod]
        public List<Inventory> GetInventoryItemsWeb()
        {
            return new InventoryController().GetInventoryItems();
        }

        [WebMethod]
        public List<Inventory> GetPlantInventoryWeb()
        {
            return new InventoryController().GetPlantInventory();
        }

        [WebMethod]
        public List<Inventory> GetWarehouseInventoryWeb()
        {
            return new InventoryController().GetWarehouseInventory();
        }

        // Web method to update inventory 
        [WebMethod]
        public int UpdateInventoryWeb(int supplierItemId, int quantity)
        {
            return new InventoryController().UpdateInventoryQuantity(supplierItemId, quantity);
        }

        //Web Method for inserting a supplier item
        [WebMethod]
        public int InsertSupplierItemWeb(int supplierId, string itemName)
        {
            SupplierItem item = new SupplierItem();
            item.SupplierId = supplierId;
            item.ItemName = itemName;
            return new SupplierItemController().InsertNewSupplierItem(item);
        }

        private SupplierItemController itemController = new SupplierItemController();

        //Web Methods for getting supplier items
        // Get SPC Supplier Items (Supplier ID = 1)
        [WebMethod]
        public List<SupplierItem> GetSPCOnlySupplierItemsWeb(int supplierId)
        {
            return itemController.GetSPCOnlySupplierItems(supplierId);
        }

        // Get Non-SPC Supplier Items (Supplier ID ≠ 1)
        [WebMethod]
        public List<SupplierItem> GetNonSPCSupplierItemsWeb(int supplierId)
        {
            return itemController.GetNonSPCSupplierItems(supplierId);
        }

        // Web method to get SPC priced orders
        [WebMethod]
        public List<Order> GetSPCPricedOrders()
        {
            return new OrderController().GetSPCPricedOrders();
        }

        // Web method to get non-SPC priced orders
        [WebMethod]
        public List<Order> GetNonSPCPricedOrders()
        {
            return new OrderController().GetNonSPCPricedOrders();
        }


        // Web method to confitm order by staff
        [WebMethod]
        public int ConfirmOrderByStaff(int orderId)
        {
            return new OrderController().ConfirmOrderByStaff(orderId);
        }
    }
}
