using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class WarehouseAddSupplierItems : Form
    {
        // Simulate supplier and item storage (replace with DB/API as needed)
        private List<Supplier> sampleSuppliers = new List<Supplier>();
        private List<SupplierItem> sampleSupplierItems = new List<SupplierItem>();

        public WarehouseAddSupplierItems()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        // Loads supplier names into combo box (simulate data here)
        private void LoadSuppliers()
        {
            // Add test suppliers
            sampleSuppliers.Add(new Supplier { SupplierId = 1, SupplierName = "PharmaCorp International" });
            sampleSuppliers.Add(new Supplier { SupplierId = 2, SupplierName = "MediSupply Solutions" });
            sampleSuppliers.Add(new Supplier { SupplierId = 3, SupplierName = "HealthPlus Distributors" });

            cmbSuppliers.Items.Clear();
            foreach (var sup in sampleSuppliers)
                cmbSuppliers.Items.Add(sup.SupplierName);

            if (cmbSuppliers.Items.Count > 0)
                cmbSuppliers.SelectedIndex = 0;
        }

        // Button click logic
        private void btnAddSupplierItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Item Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return;
            }
            if (cmbSuppliers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string supplierName = cmbSuppliers.SelectedItem.ToString();
            var selectedSupplier = sampleSuppliers.Find(s => s.SupplierName == supplierName);

            // Add item (in a real app, call API or DB insert here)
            sampleSupplierItems.Add(new SupplierItem
            {
                SupplierId = selectedSupplier.SupplierId,
                SupplierName = supplierName,
                ItemName = itemName
            });

            MessageBox.Show($"Item '{itemName}' added for supplier '{supplierName}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtItemName.Text = "";
            cmbSuppliers.SelectedIndex = 0;
        }
    }

    // Supporting test classes
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
    public class SupplierItem
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
    }
}
