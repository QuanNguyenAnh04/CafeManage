namespace CafeManagement.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainerDashboard = new SplitContainer();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnEmployee = new FontAwesome.Sharp.IconButton();
            btnBill = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnCashier = new FontAwesome.Sharp.IconButton();
            btnRevenue = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)splitContainerDashboard).BeginInit();
            splitContainerDashboard.Panel1.SuspendLayout();
            splitContainerDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerDashboard
            // 
            splitContainerDashboard.Dock = DockStyle.Fill;
            splitContainerDashboard.IsSplitterFixed = true;
            splitContainerDashboard.Location = new Point(0, 0);
            splitContainerDashboard.Name = "splitContainerDashboard";
            // 
            // splitContainerDashboard.Panel1
            // 
            splitContainerDashboard.Panel1.AutoScroll = true;
            splitContainerDashboard.Panel1.BackColor = Color.FromArgb(30, 30, 46);
            splitContainerDashboard.Panel1.Controls.Add(btnSetting);
            splitContainerDashboard.Panel1.Controls.Add(btnEmployee);
            splitContainerDashboard.Panel1.Controls.Add(btnBill);
            splitContainerDashboard.Panel1.Controls.Add(btnProduct);
            splitContainerDashboard.Panel1.Controls.Add(btnCashier);
            splitContainerDashboard.Panel1.Controls.Add(btnRevenue);
            splitContainerDashboard.Panel1.Controls.Add(label1);
            splitContainerDashboard.Panel1.Controls.Add(btnUser);
            splitContainerDashboard.Panel1.Controls.Add(btnLogout);
            // 
            // splitContainerDashboard.Panel2
            // 
            splitContainerDashboard.Panel2.BackColor = Color.WhiteSmoke;
            splitContainerDashboard.Panel2.Padding = new Padding(20);
            splitContainerDashboard.Size = new Size(1261, 835);
            splitContainerDashboard.SplitterDistance = 266;
            splitContainerDashboard.SplitterWidth = 1;
            splitContainerDashboard.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.White;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnSetting.IconColor = Color.White;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 60;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 602);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(25, 0, 0, 0);
            btnSetting.Size = new Size(245, 86);
            btnSetting.TabIndex = 21;
            btnSetting.Text = "Cài đặt";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnEmployee.IconColor = Color.White;
            btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmployee.IconSize = 60;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 516);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(25, 0, 0, 0);
            btnEmployee.Size = new Size(245, 86);
            btnEmployee.TabIndex = 20;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnStaff_Click;
            // 
            // btnBill
            // 
            btnBill.Dock = DockStyle.Top;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBill.ForeColor = Color.White;
            btnBill.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnBill.IconColor = Color.White;
            btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBill.IconSize = 60;
            btnBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnBill.Location = new Point(0, 430);
            btnBill.Name = "btnBill";
            btnBill.Padding = new Padding(25, 0, 0, 0);
            btnBill.Size = new Size(245, 86);
            btnBill.TabIndex = 19;
            btnBill.Text = "Hóa đơn";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            btnProduct.IconColor = Color.White;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 60;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 344);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(25, 0, 0, 0);
            btnProduct.Size = new Size(245, 86);
            btnProduct.TabIndex = 18;
            btnProduct.Text = "Sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCashier
            // 
            btnCashier.Dock = DockStyle.Top;
            btnCashier.FlatAppearance.BorderSize = 0;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.White;
            btnCashier.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            btnCashier.IconColor = Color.White;
            btnCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCashier.IconSize = 60;
            btnCashier.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashier.Location = new Point(0, 258);
            btnCashier.Name = "btnCashier";
            btnCashier.Padding = new Padding(25, 0, 0, 0);
            btnCashier.Size = new Size(245, 86);
            btnCashier.TabIndex = 17;
            btnCashier.Text = "Thu ngân";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.Dock = DockStyle.Top;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevenue.ForeColor = Color.White;
            btnRevenue.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnRevenue.IconColor = Color.White;
            btnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRevenue.IconSize = 60;
            btnRevenue.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevenue.Location = new Point(0, 172);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Padding = new Padding(25, 0, 0, 0);
            btnRevenue.Size = new Size(245, 86);
            btnRevenue.TabIndex = 16;
            btnRevenue.Text = "Tổng quan";
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 46);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 172);
            label1.TabIndex = 9;
            label1.Text = "Coffee shop";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Bottom;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            btnUser.IconColor = Color.White;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 60;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 688);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(25, 0, 0, 0);
            btnUser.Size = new Size(245, 86);
            btnUser.TabIndex = 8;
            btnUser.Text = "Account";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnAccount_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = Color.IndianRed;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 60;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 774);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(25, 0, 0, 0);
            btnLogout.Size = new Size(245, 86);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 835);
            Controls.Add(splitContainerDashboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += Dashboard_FormClosed;
            splitContainerDashboard.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerDashboard).EndInit();
            splitContainerDashboard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerDashboard;
        private Panel panelMainContent;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnCashier;
        private FontAwesome.Sharp.IconButton btnRevenue;
        private Label label1;
    }
}