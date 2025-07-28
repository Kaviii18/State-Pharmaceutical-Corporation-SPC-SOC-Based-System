namespace ClientApp
{
    partial class PlantStaffDashboard
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnPlaceOrders = new System.Windows.Forms.Button();
            this.btnConfirmOrders = new System.Windows.Forms.Button();
            this.btnAddSupplierItems = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 90);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.Spc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 48, 80);
            this.lblTitle.Location = new System.Drawing.Point(110, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(650, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Plant Staff Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.btnPlaceOrders);
            this.panelCard.Controls.Add(this.btnConfirmOrders);
            this.panelCard.Controls.Add(this.btnAddSupplierItems);
            this.panelCard.Location = new System.Drawing.Point(180, 130);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(440, 270);
            this.panelCard.TabIndex = 1;
            // 
            // btnAddSupplierItems
            // 
            this.btnAddSupplierItems.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnAddSupplierItems.FlatAppearance.BorderSize = 0;
            this.btnAddSupplierItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplierItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplierItems.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplierItems.Location = new System.Drawing.Point(45, 24);
            this.btnAddSupplierItems.Name = "btnAddSupplierItems";
            this.btnAddSupplierItems.Size = new System.Drawing.Size(350, 50);
            this.btnAddSupplierItems.TabIndex = 2;
            this.btnAddSupplierItems.Text = "Add Supplier Items";
            this.btnAddSupplierItems.UseVisualStyleBackColor = false;
            this.btnAddSupplierItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlaceOrders
            // 
            this.btnPlaceOrders.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnPlaceOrders.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrders.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrders.Location = new System.Drawing.Point(45, 93);
            this.btnPlaceOrders.Name = "btnPlaceOrders";
            this.btnPlaceOrders.Size = new System.Drawing.Size(350, 50);
            this.btnPlaceOrders.TabIndex = 0;
            this.btnPlaceOrders.Text = "Place Orders";
            this.btnPlaceOrders.UseVisualStyleBackColor = false;
            this.btnPlaceOrders.Click += new System.EventHandler(this.btnPlaceOrders_Click);
            // 
            // btnConfirmOrders
            // 
            this.btnConfirmOrders.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnConfirmOrders.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrders.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrders.Location = new System.Drawing.Point(45, 162);
            this.btnConfirmOrders.Name = "btnConfirmOrders";
            this.btnConfirmOrders.Size = new System.Drawing.Size(350, 50);
            this.btnConfirmOrders.TabIndex = 1;
            this.btnConfirmOrders.Text = "Confirm Orders";
            this.btnConfirmOrders.UseVisualStyleBackColor = false;
            this.btnConfirmOrders.Click += new System.EventHandler(this.btnConfirmOrders_Click);
            // 
            // PlantStaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlantStaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plant Staff Dashboard";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnPlaceOrders;
        private System.Windows.Forms.Button btnConfirmOrders;
        private System.Windows.Forms.Button btnAddSupplierItems;
    }
}

