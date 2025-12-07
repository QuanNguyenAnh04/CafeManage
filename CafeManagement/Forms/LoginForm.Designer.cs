namespace CafeManagement
{
    partial class LoginForm
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
            panelLogin = new Panel();
            lbPassword = new Label();
            lbUsername = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbLogin = new Label();
            imgBackground = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBackground).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(30, 30, 46);
            panelLogin.Controls.Add(lbPassword);
            panelLogin.Controls.Add(lbUsername);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(chkShowPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lbLogin);
            panelLogin.Location = new Point(415, 227);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(800, 600);
            panelLogin.TabIndex = 0;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(106, 269);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(111, 31);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(106, 155);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(167, 31);
            lbUsername.TabIndex = 5;
            lbUsername.Text = "Tên đăng nhập";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(180, 20, 50);
            btnLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(236, 452);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(106, 377);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(184, 35);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(106, 313);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nhập mật khẩu...";
            txtPassword.Size = new Size(587, 38);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(106, 198);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nhập tên đăng nhập...";
            txtUsername.Size = new Size(587, 45);
            txtUsername.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(301, 65);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(240, 50);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "ĐĂNG NHẬP";
            // 
            // imgBackground
            // 
            imgBackground.Dock = DockStyle.Fill;
            imgBackground.Image = Properties.Resources.background;
            imgBackground.Location = new Point(0, 0);
            imgBackground.Name = "imgBackground";
            imgBackground.Size = new Size(1582, 1055);
            imgBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBackground.TabIndex = 1;
            imgBackground.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1582, 1055);
            Controls.Add(panelLogin);
            Controls.Add(imgBackground);
            MinimumSize = new Size(800, 600);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Resize += LoginForm_Resize;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lbLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Label lbPassword;
        private Label lbUsername;
        private PictureBox imgBackground;
    }
}