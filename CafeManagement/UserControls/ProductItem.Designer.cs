namespace CafeManagement.UserControls
{
    partial class ProductItem
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
            imgProduct = new PictureBox();
            lbProductName = new Label();
            lbPrice = new Label();
            btnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)imgProduct).BeginInit();
            SuspendLayout();
            // 
            // imgProduct
            // 
            imgProduct.Dock = DockStyle.Top;
            imgProduct.Location = new Point(0, 0);
            imgProduct.Name = "imgProduct";
            imgProduct.Size = new Size(150, 105);
            imgProduct.SizeMode = PictureBoxSizeMode.Zoom;
            imgProduct.TabIndex = 0;
            imgProduct.TabStop = false;
            // 
            // lbProductName
            // 
            lbProductName.Dock = DockStyle.Top;
            lbProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductName.Location = new Point(0, 105);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(150, 28);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product";
            lbProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            lbPrice.Dock = DockStyle.Top;
            lbPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.ForeColor = Color.DarkOrchid;
            lbPrice.Location = new Point(0, 133);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(150, 28);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkOrchid;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(0, 163);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+ Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAdd);
            Controls.Add(lbPrice);
            Controls.Add(lbProductName);
            Controls.Add(imgProduct);
            DoubleBuffered = true;
            Name = "ProductItem";
            Size = new Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)imgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgProduct;
        private Label lbProductName;
        private Label lbPrice;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}
