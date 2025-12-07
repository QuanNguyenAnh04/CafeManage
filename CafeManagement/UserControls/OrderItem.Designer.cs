namespace CafeManagement.UserControls
{
    partial class OrderItem
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
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            lblProductName = new Label();
            lblPrice = new Label();
            btnDecrease = new FontAwesome.Sharp.IconButton();
            btnIncrease = new FontAwesome.Sharp.IconButton();
            tbAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imgProduct).BeginInit();
            SuspendLayout();
            // 
            // imgProduct
            // 
            imgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            imgProduct.Location = new Point(0, 0);
            imgProduct.Margin = new Padding(30, 3, 3, 3);
            imgProduct.Name = "imgProduct";
            imgProduct.Size = new Size(149, 141);
            imgProduct.TabIndex = 0;
            imgProduct.TabStop = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(172, 36);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(181, 36);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Tên món";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Gray;
            lblPrice.Location = new Point(172, 72);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(181, 41);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Giá";
            // 
            // btnDecrease
            // 
            btnDecrease.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecrease.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            btnDecrease.IconColor = Color.Black;
            btnDecrease.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDecrease.Location = new Point(408, 60);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(31, 27);
            btnDecrease.TabIndex = 3;
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncrease.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnIncrease.IconColor = Color.Black;
            btnIncrease.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIncrease.Location = new Point(559, 60);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(30, 27);
            btnIncrease.TabIndex = 4;
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(435, 60);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(127, 27);
            tbAmount.TabIndex = 5;
            tbAmount.Text = "0";
            tbAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbAmount);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(imgProduct);
            Name = "OrderItem";
            Size = new Size(613, 144);
            ((System.ComponentModel.ISupportInitialize)imgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgProduct;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Label lblProductName;
        private Label lblPrice;
        private FontAwesome.Sharp.IconButton btnDecrease;
        private FontAwesome.Sharp.IconButton btnIncrease;
        private TextBox tbAmount;
    }
}
