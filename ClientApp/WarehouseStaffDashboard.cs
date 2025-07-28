using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class WarehouseStaffDashboard : Form
    {
        public WarehouseStaffDashboard()
        {
            InitializeComponent();
        }

        private void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            // Open the Place Orders form
            WarehouseOrderForm placeOrdersForm = new WarehouseOrderForm();
            placeOrdersForm.Show();
        }

        private void btnConfirmOrders_Click(object sender, EventArgs e)
        {
            // Open the Confirm Orders form
            WarehouseOrderConfirmForm confirmOrdersForm = new WarehouseOrderConfirmForm();
            confirmOrdersForm.Show();
        }

        private void btnAddSupplierItems_Click(object sender, EventArgs e)
        {
            // Open the Add Supplier Items form
            WarehouseAddSupplierItems addSupplierItemsForm = new WarehouseAddSupplierItems();
            addSupplierItemsForm.Show();
        }
    }
}
