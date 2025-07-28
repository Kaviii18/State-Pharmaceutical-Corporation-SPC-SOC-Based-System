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
    public partial class SupplierLoginForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public SupplierLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;

            var supplier = soapClient.LoginSupplierWeb(email, password);
            if (supplier != null)
            {
                MessageBox.Show("Login successful!");
                new SupplierOrderForm(supplier.SupplierId).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
