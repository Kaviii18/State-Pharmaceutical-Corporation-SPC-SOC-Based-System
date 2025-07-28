using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SupplierManagemenet.Models
{
    public class Supplier 
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPassword { get; set; }
    }
}