using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClientApp
{
    public partial class WarehouseOrderForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public WarehouseOrderForm()
        {
            InitializeComponent();
            LoadNonSPCSuppliers();
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Enable full-row selection
            cmbSuppliers.SelectedIndexChanged += cmbSuppliers_SelectedIndexChanged; // Attach event handler
        }

        // Load non-SPC suppliers into combo box
        private void LoadNonSPCSuppliers()
        {
            var suppliers = soapClient.GetNonSPCSuppliersWeb();

            // Create a DataTable with a "Select Supplier" default option
            DataTable dtSuppliers = new DataTable();
            dtSuppliers.Columns.Add("SupplierId", typeof(int));
            dtSuppliers.Columns.Add("SupplierName", typeof(string));

            // Add "Select Supplier" as the first row
            dtSuppliers.Rows.Add(0, "Select Supplier");

            // Add the rest of the suppliers
            foreach (var supplier in suppliers)
            {
                dtSuppliers.Rows.Add(supplier.SupplierId, supplier.SupplierName);
            }

            // Bind to combo box
            cmbSuppliers.DataSource = dtSuppliers;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "SupplierId";

            // Set default selection to "Select Supplier"
            cmbSuppliers.SelectedIndex = 0;
        }

        // Load supplier items when a supplier is selected
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedValue is int supplierId && supplierId > 0)
            {
                LoadNonSPCSupplierItems(supplierId);
            }
            else
            {
                dgvItems.DataSource = null; // Clear items if "Select Supplier" is chosen
            }
        }

        // Load supplier-specific items into DataGridView
        private void LoadNonSPCSupplierItems(int supplierId)
        {
            var items = soapClient.GetNonSPCSupplierItemsWeb(supplierId);
            dgvItems.DataSource = items;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvItems.SelectedRows[0];

                if (!int.TryParse(textQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
                if (supplierId == 0)
                {
                    MessageBox.Show("Please select a valid supplier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int supplierItemId = Convert.ToInt32(selectedRow.Cells["SupplierItemId"].Value);
                int orderId = soapClient.PlaceOrderWeb(supplierId, "Warehouse", supplierItemId, quantity);

                if (orderId > 0)
                {
                    MessageBox.Show("Order placed successfully!");
                }
                else
                {
                    MessageBox.Show("Order placement failed. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to order.");
            }
        }
    }
}
