namespace CafeManagement.UserControls.Setting
{
    partial class ucSetting
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
            panelTop = new Panel();
            lblTable = new Label();
            btnAddTable = new Button();
            lblTitle = new Label();
            panelContent = new Panel();
            flpTables = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Transparent;
            panelTop.Controls.Add(lblTable);
            panelTop.Controls.Add(btnAddTable);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(585, 147);
            panelTop.TabIndex = 0;
            // 
            // lblTable
            // 
            lblTable.Anchor = AnchorStyles.Left;
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTable.Location = new Point(87, 85);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(131, 30);
            lblTable.TabIndex = 1;
            lblTable.Text = "Quản lý Bàn";
            // 
            // btnAddTable
            // 
            btnAddTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTable.AutoSize = true;
            btnAddTable.BackColor = Color.FromArgb(192, 255, 255);
            btnAddTable.FlatStyle = FlatStyle.Popup;
            btnAddTable.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTable.ForeColor = Color.FromArgb(192, 0, 0);
            btnAddTable.Location = new Point(364, 81);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(140, 40);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "+ Thêm bàn";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(46, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cài đặt hệ thống";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(flpTables);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 147);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(10);
            panelContent.Size = new Size(585, 454);
            panelContent.TabIndex = 1;
            // 
            // flpTables
            // 
            flpTables.AutoScroll = true;
            flpTables.BackColor = Color.Transparent;
            flpTables.Dock = DockStyle.Fill;
            flpTables.Location = new Point(10, 10);
            flpTables.Margin = new Padding(0);
            flpTables.Name = "flpTables";
            flpTables.Padding = new Padding(10);
            flpTables.Size = new Size(565, 434);
            flpTables.TabIndex = 0;
            // 
            // ucSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "ucSetting";
            Size = new Size(585, 601);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnAddTable;
        private Label lblTable;
        private Label lblTitle;
        private Panel panelContent;
        private FlowLayoutPanel flpTables;
    }
}
