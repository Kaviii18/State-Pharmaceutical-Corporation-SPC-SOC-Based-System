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
    public partial class PlantAddSupplierItems : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public PlantAddSupplierItems()
        {
            InitializeComponent();
            LoadSPCSuppliers();
        }

        private void LoadSPCSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>((IEnumerable<Supplier>)soapClient.GetSPCSuppliersWeb());
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "SupplierId";
            cmbSuppliers.SelectedIndex = -1; // Default selection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
            string itemName = txtItemName.Text.Trim();

            int result = soapClient.InsertSupplierItemWeb(supplierId, itemName);

            if (result > 0)
            {
                MessageBox.Show("Item added successfully!");
                txtItemName.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add item.");
            }
        }
    }
}
