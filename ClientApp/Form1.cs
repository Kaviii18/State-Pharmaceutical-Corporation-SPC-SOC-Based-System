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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSupRegistration_Click(object sender, EventArgs e)
        {
            SupplierRegistrationForm supplierRegistrationForm = new SupplierRegistrationForm();
            supplierRegistrationForm.Show();
        }

        private void btnSupplierLogin_Click(object sender, EventArgs e)
        {
            SupplierLoginForm supplierLoginForm = new SupplierLoginForm();
            supplierLoginForm.Show();
        }

        private void btnPlantStaffLogin_Click(object sender, EventArgs e)
        {
            PlantStaffLoginForm plantStaffLoginForm = new PlantStaffLoginForm();
            plantStaffLoginForm.Show();
        }

        private void btnWarehouseStaffLogin_Click(object sender, EventArgs e)
        {
            WarehouseStaffLogin warehouseStaffLogin = new WarehouseStaffLogin();
            warehouseStaffLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // else do nothing, user cancelled logout
        }

    }
}
