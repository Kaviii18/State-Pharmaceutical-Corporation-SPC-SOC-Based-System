using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SupplierManagemenet.Models
{
    public class SupplierItem 
    {
        public int SupplierItemId { get; set; }
        public int SupplierId { get; set; }
        public string ItemName { get; set; }
    }
}