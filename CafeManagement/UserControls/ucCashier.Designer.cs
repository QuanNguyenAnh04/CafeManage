namespace CafeManagement.Forms
{
    partial class ucCashier
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panelTables = new FlowLayoutPanel();
            lbTable = new Label();
            panelProducts = new FlowLayoutPanel();
            splitContainer3 = new SplitContainer();
            panelCategories = new FlowLayoutPanel();
            searchBox = new TextBox();
            label5 = new Label();
            panelOrders = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            lblTotalPrice = new Label();
            btnChangeTable = new FontAwesome.Sharp.IconButton();
            numDiscount = new NumericUpDown();
            label4 = new Label();
            lblTmpTotalPrice = new Label();
            btnPay = new FontAwesome.Sharp.IconButton();
            panelTitleBill = new Panel();
            lblTitleTable = new Label();
            lbTitleOrderID = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            panelTitleBill.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(panelOrders);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(btnPay);
            splitContainer1.Panel2.Controls.Add(panelTitleBill);
            splitContainer1.Size = new Size(1131, 707);
            splitContainer1.SplitterDistance = 644;
            splitContainer1.SplitterWidth = 25;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.White;
            splitContainer2.Panel1.Controls.Add(panelTables);
            splitContainer2.Panel1.Controls.Add(lbTable);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(panelProducts);
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(644, 707);
            splitContainer2.SplitterDistance = 231;
            splitContainer2.SplitterWidth = 25;
            splitContainer2.TabIndex = 0;
            // 
            // panelTables
            // 
            panelTables.Dock = DockStyle.Fill;
            panelTables.Location = new Point(0, 73);
            panelTables.Name = "panelTables";
            panelTables.Size = new Size(644, 158);
            panelTables.TabIndex = 1;
            // 
            // lbTable
            // 
            lbTable.Dock = DockStyle.Top;
            lbTable.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTable.Location = new Point(0, 0);
            lbTable.Name = "lbTable";
            lbTable.Padding = new Padding(25, 0, 0, 0);
            lbTable.Size = new Size(644, 73);
            lbTable.TabIndex = 0;
            lbTable.Text = "Sơ đồ bàn";
            lbTable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelProducts
            // 
            panelProducts.AutoScroll = true;
            panelProducts.Dock = DockStyle.Fill;
            panelProducts.Location = new Point(0, 94);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(644, 357);
            panelProducts.TabIndex = 3;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Top;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(panelCategories);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(searchBox);
            splitContainer3.Panel2.Controls.Add(label5);
            splitContainer3.Panel2.Padding = new Padding(15, 30, 15, 15);
            splitContainer3.Size = new Size(644, 94);
            splitContainer3.SplitterDistance = 398;
            splitContainer3.TabIndex = 2;
            // 
            // panelCategories
            // 
            panelCategories.AutoScroll = true;
            panelCategories.Dock = DockStyle.Fill;
            panelCategories.Location = new Point(0, 0);
            panelCategories.Name = "panelCategories";
            panelCategories.Padding = new Padding(0, 15, 0, 0);
            panelCategories.Size = new Size(398, 94);
            panelCategories.TabIndex = 0;
            panelCategories.WrapContents = false;
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Fill;
            searchBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(15, 30);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Tìm kiếm sản phẩm...";
            searchBox.Size = new Size(212, 30);
            searchBox.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(15, 30);
            label5.Name = "label5";
            label5.Size = new Size(212, 49);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // panelOrders
            // 
            panelOrders.Dock = DockStyle.Fill;
            panelOrders.Location = new Point(0, 113);
            panelOrders.Name = "panelOrders";
            panelOrders.Padding = new Padding(0, 20, 0, 0);
            panelOrders.Size = new Size(462, 325);
            panelOrders.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblTotalPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(btnChangeTable, 0, 0);
            tableLayoutPanel1.Controls.Add(numDiscount, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTmpTotalPrice, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(0, 438);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.70092F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6495438F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6495438F));
            tableLayoutPanel1.Size = new Size(462, 194);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 135);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 0, 40, 0);
            label2.Size = new Size(225, 56);
            label2.TabIndex = 1;
            label2.Text = "Tổng cộng";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Dock = DockStyle.Fill;
            lblTotalPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ImageAlign = ContentAlignment.MiddleRight;
            lblTotalPrice.Location = new Point(234, 135);
            lblTotalPrice.Margin = new Padding(3);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Padding = new Padding(10, 0, 30, 0);
            lblTotalPrice.Size = new Size(225, 56);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "00.000 đ";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnChangeTable
            // 
            btnChangeTable.AutoSize = true;
            btnChangeTable.BackColor = Color.White;
            btnChangeTable.Dock = DockStyle.Fill;
            btnChangeTable.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnChangeTable.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeTable.ForeColor = SystemColors.ControlDarkDark;
            btnChangeTable.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnChangeTable.IconColor = SystemColors.ControlDarkDark;
            btnChangeTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeTable.IconSize = 35;
            btnChangeTable.Location = new Point(30, 10);
            btnChangeTable.Margin = new Padding(30, 10, 10, 0);
            btnChangeTable.Name = "btnChangeTable";
            btnChangeTable.Padding = new Padding(3);
            btnChangeTable.Size = new Size(191, 61);
            btnChangeTable.TabIndex = 3;
            btnChangeTable.Text = "Đổi bàn";
            btnChangeTable.TextAlign = ContentAlignment.MiddleRight;
            btnChangeTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangeTable.UseVisualStyleBackColor = false;
            btnChangeTable.Click += btnChangeTable_Click;
            // 
            // numDiscount
            // 
            numDiscount.DecimalPlaces = 1;
            numDiscount.Dock = DockStyle.Fill;
            numDiscount.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numDiscount.Location = new Point(241, 22);
            numDiscount.Margin = new Padding(10, 22, 30, 0);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(191, 41);
            numDiscount.TabIndex = 4;
            numDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(3, 71);
            label4.Name = "label4";
            label4.Padding = new Padding(30, 0, 20, 0);
            label4.Size = new Size(225, 61);
            label4.TabIndex = 5;
            label4.Text = "Tạm tính";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTmpTotalPrice
            // 
            lblTmpTotalPrice.AutoSize = true;
            lblTmpTotalPrice.Dock = DockStyle.Fill;
            lblTmpTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTmpTotalPrice.ForeColor = SystemColors.ControlDarkDark;
            lblTmpTotalPrice.Location = new Point(234, 71);
            lblTmpTotalPrice.Name = "lblTmpTotalPrice";
            lblTmpTotalPrice.Padding = new Padding(10, 0, 30, 0);
            lblTmpTotalPrice.Size = new Size(225, 61);
            lblTmpTotalPrice.TabIndex = 6;
            lblTmpTotalPrice.Text = "00.000 đ";
            lblTmpTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(180, 20, 50);
            btnPay.Dock = DockStyle.Bottom;
            btnPay.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnPay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            btnPay.IconColor = Color.White;
            btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPay.Location = new Point(0, 632);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(462, 75);
            btnPay.TabIndex = 1;
            btnPay.Text = "Thanh toán";
            btnPay.TextAlign = ContentAlignment.MiddleRight;
            btnPay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // panelTitleBill
            // 
            panelTitleBill.BackColor = Color.Lavender;
            panelTitleBill.Controls.Add(lblTitleTable);
            panelTitleBill.Controls.Add(lbTitleOrderID);
            panelTitleBill.Controls.Add(label1);
            panelTitleBill.Dock = DockStyle.Top;
            panelTitleBill.Location = new Point(0, 0);
            panelTitleBill.Name = "panelTitleBill";
            panelTitleBill.Size = new Size(462, 113);
            panelTitleBill.TabIndex = 0;
            // 
            // lblTitleTable
            // 
            lblTitleTable.AutoSize = true;
            lblTitleTable.Dock = DockStyle.Right;
            lblTitleTable.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleTable.ForeColor = Color.BlueViolet;
            lblTitleTable.Location = new Point(357, 0);
            lblTitleTable.Name = "lblTitleTable";
            lblTitleTable.Padding = new Padding(0, 15, 25, 0);
            lblTitleTable.Size = new Size(105, 50);
            lblTitleTable.TabIndex = 2;
            lblTitleTable.Text = "Bàn 0";
            // 
            // lbTitleOrderID
            // 
            lbTitleOrderID.AutoSize = true;
            lbTitleOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitleOrderID.ForeColor = SystemColors.ControlDarkDark;
            lbTitleOrderID.Location = new Point(31, 58);
            lbTitleOrderID.Name = "lbTitleOrderID";
            lbTitleOrderID.Size = new Size(146, 28);
            lbTitleOrderID.TabIndex = 1;
            lbTitleOrderID.Text = "Order #000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 38);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ucCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ucCashier";
            Size = new Size(1131, 707);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            panelTitleBill.ResumeLayout(false);
            panelTitleBill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel panelTables;
        private Label lbTable;
        private Panel panelTitleBill;
        private Label label1;
        private Label lbTitleOrderID;
        private Label lblTitleTable;
        private FontAwesome.Sharp.IconButton btnPay;
        private FlowLayoutPanel panelOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label lblTotalPrice;
        private FontAwesome.Sharp.IconButton btnChangeTable;
        private NumericUpDown numDiscount;
        private Label label4;
        private Label lblTmpTotalPrice;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel panelProducts;
        private FlowLayoutPanel panelCategories;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox searchBox;
        private Label label5;
    }
}
