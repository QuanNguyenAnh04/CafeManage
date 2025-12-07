namespace CafeManagement.Forms.Employee
{
    partial class AddEmployeeForm
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
            panelMain = new Panel();
            btnCreate = new Button();
            btnCancel = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            lblName = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.Fixed3D;
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(cmbRole);
            panelMain.Controls.Add(lblRole);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(txtFullName);
            panelMain.Controls.Add(lblName);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(lblUser);
            panelMain.Controls.Add(lblTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(410, 512);
            panelMain.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(214, 0, 160);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(230, 434);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 40);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Tạo tài khoản";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(233, 233, 233);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(59, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Nhân viên", "Quản trị" });
            cmbRole.Location = new Point(25, 360);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(350, 28);
            cmbRole.TabIndex = 8;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            cmbRole.Click += AddEmployeeForm_Load;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(25, 330);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(47, 17);
            lblRole.TabIndex = 7;
            lblRole.Text = "Vai trò";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(25, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 27);
            txtPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 240);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.Gray;
            txtFullName.Location = new Point(25, 185);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 27);
            txtFullName.TabIndex = 4;
            txtFullName.Text = "vd: Nguyễn Văn A";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(25, 160);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 17);
            lblName.TabIndex = 3;
            lblName.Text = "Họ và tên";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(244, 244, 244);
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(25, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "vd: staff01";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(25, 85);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(99, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(65, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm nhân viên mới";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(410, 512);
            Controls.Add(panelMain);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm nhân viên";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblUser;
        private Label lblTitle;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtFullName;
        private Label lblName;
        private TextBox txtUsername;
        private Label lblRole;
        private Button btnCreate;
        private Button btnCancel;
        private ComboBox cmbRole;
    }
}