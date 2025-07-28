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
    public partial class PlantOrderForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public PlantOrderForm()
        {
            InitializeComponent();
            LoadSPCSuppliers();
            LoadSupplierItems();
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Load SPC suppliers into combo box
        private void LoadSPCSuppliers()
        {
            var suppliers = soapClient.GetSPCSuppliersWeb();
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "SupplierId";
        }

        // Load supplier items once when the form loads
        private void LoadSupplierItems()
        {
            var items = soapClient.GetSPCOnlySupplierItemsWeb(1); // SPC Supplier ID is always 1
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
                int supplierItemId = Convert.ToInt32(selectedRow.Cells["SupplierItemId"].Value);

                int orderId = soapClient.PlaceOrderWeb(supplierId, "Plant", supplierItemId, quantity);

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
