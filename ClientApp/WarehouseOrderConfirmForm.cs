using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.SupplierService;

namespace ClientApp
{
    public partial class WarehouseOrderConfirmForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public WarehouseOrderConfirmForm()
        {
            InitializeComponent();
            LoadNonSPCOrders();
            LoadInventoryItems();
        }

        private void LoadNonSPCOrders()
        {
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear(); // Clear existing columns before adding new ones
            // Define columns
            dgvOrders.Columns.Add("OrderId", "Order ID");
            dgvOrders.Columns.Add("SupplierItemId", "Supplier Item ID");
            dgvOrders.Columns.Add("Quantity", "Quantity");
            dgvOrders.Columns.Add("UnitPrice", "Unit Price");
            List<Order> orders = soapClient.GetNonSPCPricedOrders(); // Fetch Non-SPC orders
            foreach (var order in orders)
            {
                dgvOrders.Rows.Add(order.OrderId, order.SupplierItemId, order.Quantity, order.UnitPrice);
            }
        }

        private void LoadInventoryItems()
        {
            try
            {
                var inventoryItems = soapClient.GetInventoryItemsWeb();

                if (inventoryItems != null)
                {
                    dgvInventory.DataSource = inventoryItems;
                    dgvInventory.Columns["InventoryId"].Visible = false; // Hide inventoryId if not needed
                    dgvInventory.Columns["SupItemId"].Visible = true; 
                    dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No inventory items found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to confirm.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[0].Value); // Get selected orderId

            int result = soapClient.ConfirmOrderByStaff(orderId); // Call web method

            if (result > 0)
            {
                MessageBox.Show("Order confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNonSPCOrders(); // Refresh order list after confirmation
                LoadInventoryItems(); //refresh inventory items
            }
            else
            {
                MessageBox.Show("Order confirmation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseOrderConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
