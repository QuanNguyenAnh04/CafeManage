namespace CafeManagement.Forms
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1 = new Panel();
            lblDate = new Label();
            lblTable = new Label();
            label1 = new Label();
            btnPrintBill = new Button();
            lblTotalPrice = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgvOrders = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblTable);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 132);
            panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Bottom;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(0, 94);
            lblDate.Name = "lblDate";
            lblDate.Padding = new Padding(30, 0, 30, 0);
            lblDate.Size = new Size(452, 38);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày: ";
            // 
            // lblTable
            // 
            lblTable.Dock = DockStyle.Top;
            lblTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTable.Location = new Point(0, 53);
            lblTable.Name = "lblTable";
            lblTable.Padding = new Padding(30, 0, 30, 0);
            lblTable.Size = new Size(452, 41);
            lblTable.TabIndex = 1;
            lblTable.Text = "Bàn: ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(452, 53);
            label1.TabIndex = 0;
            label1.Text = "Coffee Shop";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.RoyalBlue;
            btnPrintBill.Dock = DockStyle.Bottom;
            btnPrintBill.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintBill.ForeColor = Color.White;
            btnPrintBill.Location = new Point(0, 493);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(452, 60);
            btnPrintBill.TabIndex = 1;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Dock = DockStyle.Bottom;
            lblTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(0, 445);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Padding = new Padding(30, 0, 30, 0);
            lblTotalPrice.Size = new Size(452, 48);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "Tổng: ";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 2);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 1);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 1);
            panel4.TabIndex = 7;
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { STT, ProductName, Amount, Price });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 135);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(452, 309);
            dgvOrders.TabIndex = 8;
            // 
            // STT
            // 
            STT.FillWeight = 53.47594F;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            ProductName.FillWeight = 210.018936F;
            ProductName.HeaderText = "Tên món";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            Amount.FillWeight = 57.02662F;
            Amount.HeaderText = "Số lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            Price.FillWeight = 79.47854F;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 553);
            Controls.Add(dgvOrders);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnPrintBill);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button btnPrintBill;
        private Label label1;
        private Label lblDate;
        private Label lblTable;
        private Label lblTotalPrice;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Price;
    }
}