namespace CafeManagement.UserControls.Employee
{
    partial class ucEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblTitle = new Label();
            flowEmployees = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnAdd);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(661, 100);
            panelHeader.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(521, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(304, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 1;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý nhân viên";
            // 
            // flowEmployees
            // 
            flowEmployees.AutoScroll = true;
            flowEmployees.Dock = DockStyle.Fill;
            flowEmployees.Location = new Point(0, 100);
            flowEmployees.Name = "flowEmployees";
            flowEmployees.Size = new Size(661, 334);
            flowEmployees.TabIndex = 1;
            // 
            // ucEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowEmployees);
            Controls.Add(panelHeader);
            Name = "ucEmployee";
            Size = new Size(661, 434);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private TextBox txtSearch;
        private Label lblTitle;
        private Button btnAdd;
        private FlowLayoutPanel flowEmployees;
    }
}
