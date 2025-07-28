using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace SupplierManagemenet.Models
{
    public class Inventory 
    {
        public int InventoryId { get; set; }

        public string SupplierName { get; set; }
        public int SupItemId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
    }
}