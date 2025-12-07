namespace CafeManagement.UserControls.Products
{
    partial class ucProductPage
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
            panelLeft = new Panel();
            flowCategory = new FlowLayoutPanel();
            btnAddCategory = new Button();
            lblCategoryTitle = new Label();
            panelRight = new Panel();
            flowProduct = new FlowLayoutPanel();
            btnAddProduct = new Button();
            lblProductTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Size = new Size(539, 518);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(flowCategory);
            panelLeft.Controls.Add(btnAddCategory);
            panelLeft.Controls.Add(lblCategoryTitle);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(178, 518);
            panelLeft.TabIndex = 0;
            // 
            // flowCategory
            // 
            flowCategory.AutoScroll = true;
            flowCategory.AutoSize = true;
            flowCategory.BackColor = Color.Transparent;
            flowCategory.FlowDirection = FlowDirection.TopDown;
            flowCategory.Location = new Point(0, 84);
            flowCategory.Name = "flowCategory";
            flowCategory.Padding = new Padding(0, 5, 0, 0);
            flowCategory.Size = new Size(178, 434);
            flowCategory.TabIndex = 2;
            flowCategory.WrapContents = false;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.MediumPurple;
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(127, 18);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(35, 35);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.Location = new Point(20, 20);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(101, 25);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Danh Mục";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(flowProduct);
            panelRight.Controls.Add(btnAddProduct);
            panelRight.Controls.Add(lblProductTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(357, 518);
            panelRight.TabIndex = 0;
            // 
            // flowProduct
            // 
            flowProduct.AutoScroll = true;
            flowProduct.AutoSize = true;
            flowProduct.Location = new Point(0, 84);
            flowProduct.Name = "flowProduct";
            flowProduct.Size = new Size(357, 434);
            flowProduct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.MediumPurple;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(201, 20);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(124, 37);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "+ Thêm món";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProductTitle
            // 
            lblProductTitle.AutoSize = true;
            lblProductTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductTitle.Location = new Point(36, 20);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(145, 25);
            lblProductTitle.TabIndex = 0;
            lblProductTitle.Text = "Danh sách món";
            // 
            // ucProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ucProductPage";
            Size = new Size(539, 518);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panelLeft;
        private Label lblCategoryTitle;
        private Panel panelRight;
        private FlowLayoutPanel flowCategory;
        private Button btnAddCategory;
        private Label lblProductTitle;
        private FlowLayoutPanel flowProduct;
        private Button btnAddProduct;
    }
}
