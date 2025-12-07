namespace CafeManagement.UserControls.Products
{
    partial class ucProductCard
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
            panelCard = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            lblPrice = new Label();
            lblName = new Label();
            picImage = new PictureBox();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(btnDelete);
            panelCard.Controls.Add(btnEdit);
            panelCard.Controls.Add(lblPrice);
            panelCard.Controls.Add(lblName);
            panelCard.Controls.Add(picImage);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(180, 220);
            panelCard.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightBlue;
            btnDelete.Location = new Point(108, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 25);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(32, 178);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(40, 25);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.MediumPurple;
            lblPrice.Location = new Point(11, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(160, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "0 đ";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(20, 127);
            lblName.MaximumSize = new Size(140, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Tên sản phẩm";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            picImage.BackColor = Color.White;
            picImage.Location = new Point(12, 15);
            picImage.Name = "picImage";
            picImage.Size = new Size(150, 100);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // ucProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelCard);
            Margin = new Padding(10);
            Name = "ucProductCard";
            Size = new Size(180, 220);
            panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private PictureBox picImage;
        private Label lblName;
        private Label lblPrice;
        private Button btnDelete;
        private Button btnEdit;
    }
}
