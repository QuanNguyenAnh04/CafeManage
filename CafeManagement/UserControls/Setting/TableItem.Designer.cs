namespace CafeManagement.UserControls.Setting
{
    partial class TableItem
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
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            lblStatus = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblName);
            //panel1.Location = new Point(10, 10);
            panel1.Dock = DockStyle.Fill;   
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 140);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(74, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 25);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(10, 101);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 25);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(3, 52);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 46);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Trống";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Dock = DockStyle.Top;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 52);
            lblName.TabIndex = 0;
            lblName.Text = "Bàn";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "TableItem";
            Padding = new Padding(10);
            Size = new Size(163, 160);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

            this.Margin = new Padding(10);
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label lblStatus;
        private Button btnDelete;
        private Button btnEdit;
    }
}
