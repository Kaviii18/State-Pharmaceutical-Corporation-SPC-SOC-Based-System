using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SupplierManagemenet.Models
{
    public class Order 
    {
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public int SupplierItemId { get; set; }
        public string StaffType { get; set; } 
        public string OrderStatus { get; set; } 
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; } 

        public string ItemName { get; set; }

        public string SupplierName { get; set; }
    }
}