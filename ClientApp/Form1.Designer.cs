namespace ClientApp
{
    partial class Form1
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
            this.btnSupplierLogin = new System.Windows.Forms.Button();
            this.btnSupRegistration = new System.Windows.Forms.Button();
            this.btnPlantStaffLogin = new System.Windows.Forms.Button();
            this.btnWarehouseStaffLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button(); // NEW LOGOUT BUTTON
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
            this.panelTop.Size = new System.Drawing.Size(800, 120);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.Spc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 48, 80);
            this.lblTitle.Location = new System.Drawing.Point(135, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(650, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SPC Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.btnSupplierLogin);
            this.panelCard.Controls.Add(this.btnSupRegistration);
            this.panelCard.Controls.Add(this.btnPlantStaffLogin);
            this.panelCard.Controls.Add(this.btnWarehouseStaffLogin);
            this.panelCard.Controls.Add(this.btnLogout); // ADD LOGOUT BUTTON
            this.panelCard.Location = new System.Drawing.Point(170, 170);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(460, 330); // increased height to fit Logout
            this.panelCard.TabIndex = 1;
            // 
            // btnSupplierLogin
            // 
            this.btnSupplierLogin.BackColor = System.Drawing.Color.FromArgb(30, 48, 80);
            this.btnSupplierLogin.FlatAppearance.BorderSize = 0;
            this.btnSupplierLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupplierLogin.ForeColor = System.Drawing.Color.White;
            this.btnSupplierLogin.Location = new System.Drawing.Point(48, 30);
            this.btnSupplierLogin.Name = "btnSupplierLogin";
            this.btnSupplierLogin.Size = new System.Drawing.Size(364, 42);
            this.btnSupplierLogin.TabIndex = 0;
            this.btnSupplierLogin.Text = "Supplier Login";
            this.btnSupplierLogin.UseVisualStyleBackColor = false;
            this.btnSupplierLogin.Click += new System.EventHandler(this.btnSupplierLogin_Click);
            // 
            // btnSupRegistration
            // 
            this.btnSupRegistration.BackColor = System.Drawing.Color.FromArgb(34, 166, 179);
            this.btnSupRegistration.FlatAppearance.BorderSize = 0;
            this.btnSupRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupRegistration.ForeColor = System.Drawing.Color.White;
            this.btnSupRegistration.Location = new System.Drawing.Point(48, 82);
            this.btnSupRegistration.Name = "btnSupRegistration";
            this.btnSupRegistration.Size = new System.Drawing.Size(364, 42);
            this.btnSupRegistration.TabIndex = 1;
            this.btnSupRegistration.Text = "Supplier Registration";
            this.btnSupRegistration.UseVisualStyleBackColor = false;
            this.btnSupRegistration.Click += new System.EventHandler(this.btnSupRegistration_Click);
            // 
            // btnPlantStaffLogin
            // 
            this.btnPlantStaffLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnPlantStaffLogin.FlatAppearance.BorderSize = 0;
            this.btnPlantStaffLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantStaffLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlantStaffLogin.ForeColor = System.Drawing.Color.White;
            this.btnPlantStaffLogin.Location = new System.Drawing.Point(48, 134);
            this.btnPlantStaffLogin.Name = "btnPlantStaffLogin";
            this.btnPlantStaffLogin.Size = new System.Drawing.Size(364, 42);
            this.btnPlantStaffLogin.TabIndex = 2;
            this.btnPlantStaffLogin.Text = "Plant Staff Login";
            this.btnPlantStaffLogin.UseVisualStyleBackColor = false;
            this.btnPlantStaffLogin.Click += new System.EventHandler(this.btnPlantStaffLogin_Click);
            // 
            // btnWarehouseStaffLogin
            // 
            this.btnWarehouseStaffLogin.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnWarehouseStaffLogin.FlatAppearance.BorderSize = 0;
            this.btnWarehouseStaffLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouseStaffLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnWarehouseStaffLogin.ForeColor = System.Drawing.Color.White;
            this.btnWarehouseStaffLogin.Location = new System.Drawing.Point(48, 186);
            this.btnWarehouseStaffLogin.Name = "btnWarehouseStaffLogin";
            this.btnWarehouseStaffLogin.Size = new System.Drawing.Size(364, 42);
            this.btnWarehouseStaffLogin.TabIndex = 3;
            this.btnWarehouseStaffLogin.Text = "Warehouse Staff Login";
            this.btnWarehouseStaffLogin.UseVisualStyleBackColor = false;
            this.btnWarehouseStaffLogin.Click += new System.EventHandler(this.btnWarehouseStaffLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(48, 238); // Position below last button
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(364, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPC Management System";
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
        private System.Windows.Forms.Button btnSupplierLogin;
        private System.Windows.Forms.Button btnSupRegistration;
        private System.Windows.Forms.Button btnPlantStaffLogin;
        private System.Windows.Forms.Button btnWarehouseStaffLogin;
        private System.Windows.Forms.Button btnLogout; // <--- Add this!
    }
}




