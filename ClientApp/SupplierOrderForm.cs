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
    public partial class SupplierOrderForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        private int supplierId;

        public SupplierOrderForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            LoadOrders();
        }

        // Load pending orders
        private void LoadOrders()
        {
            var orders = soapClient.GetSupplierOrdersWeb(supplierId);
            dgvOrders.DataSource = orders;
        }


        private void btnAddSupItems_Click(object sender, EventArgs e)
        {

        }

        //Update Price
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0) // Ensure a row is selected
            {
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];

                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);

                // Get unit price from txtUnitPrice
                if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) && unitPrice > 0)
                {
                    soapClient.UpdateOrderPriceWeb(orderId, unitPrice);

                    MessageBox.Show("Unit price updated successfully!");
                    LoadOrders(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Please enter a valid unit price.");
                }

            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];

                if (selectedRow.Cells["OrderId"].Value != null)
                {
                    int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                    soapClient.ConfirmOrderWeb(orderId);

                    MessageBox.Show("Order Priced!");
                    LoadOrders(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Invalid order selected.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to confirm.");
            }
        }

        private void SupplierOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
