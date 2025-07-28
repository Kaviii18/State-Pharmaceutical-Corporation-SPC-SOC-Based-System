using System.Drawing;

namespace ClientApp
{
    partial class WarehouseAddSupplierItems
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAddSupplierItem;
        private System.Windows.Forms.ComboBox cmbSuppliers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAddSupplierItem = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new System.Drawing.Point(230, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Supplier Items";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSupplier.Location = new System.Drawing.Point(120, 85);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(82, 25);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblItemName.Location = new System.Drawing.Point(120, 137);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(102, 25);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name:";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(230, 82);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(350, 33);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItemName.Location = new System.Drawing.Point(230, 134);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(350, 32);
            this.txtItemName.TabIndex = 4;
            // 
            // btnAddSupplierItem
            // 
            this.btnAddSupplierItem.BackColor = Color.FromArgb(34, 197, 94);
            this.btnAddSupplierItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplierItem.ForeColor = Color.White;
            this.btnAddSupplierItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplierItem.FlatAppearance.BorderSize = 0;
            this.btnAddSupplierItem.Location = new System.Drawing.Point(295, 195);
            this.btnAddSupplierItem.Name = "btnAddSupplierItem";
            this.btnAddSupplierItem.Size = new System.Drawing.Size(180, 45);
            this.btnAddSupplierItem.TabIndex = 5;
            this.btnAddSupplierItem.Text = "Add Supplier Item";
            this.btnAddSupplierItem.UseVisualStyleBackColor = false;
            this.btnAddSupplierItem.Click += new System.EventHandler(this.btnAddSupplierItem_Click);
            // 
            // WarehouseAddSupplierItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 239, 241);
            this.ClientSize = new System.Drawing.Size(700, 270);
            this.Controls.Add(this.btnAddSupplierItem);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WarehouseAddSupplierItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier Items";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
