using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class SupplierRegistrationForm : Form
    {
        //Create web service reference
        SupplierService.SupplierManagementWebServiceSoapClient soapClient =
        new SupplierService.SupplierManagementWebServiceSoapClient();

        public SupplierRegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            int result = soapClient.InsertSupplierWeb(name, contact, email, password);
            if (result > 0)
            {
                MessageBox.Show("Supplier registered successfully!");
                txtName.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
            } 
            else
                MessageBox.Show("Error registering supplier.");
            
        }
    }
}
