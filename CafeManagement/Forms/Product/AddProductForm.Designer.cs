namespace CafeManagement.Forms.Product
{
    partial class AddProductForm
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            picImage = new PictureBox();
            btnChooseImg = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(79, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm sản phẩm mới";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Tên món";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(24, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Giá";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(110, 95);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(140, 23);
            nudPrice.TabIndex = 4;
            // 
            // picImage
            // 
            picImage.BackColor = SystemColors.GradientInactiveCaption;
            picImage.Location = new Point(110, 130);
            picImage.Name = "picImage";
            picImage.Size = new Size(120, 120);
            picImage.TabIndex = 5;
            picImage.TabStop = false;
            // 
            // btnChooseImg
            // 
            btnChooseImg.Location = new Point(240, 170);
            btnChooseImg.Name = "btnChooseImg";
            btnChooseImg.Size = new Size(75, 23);
            btnChooseImg.TabIndex = 6;
            btnChooseImg.Text = "Chọn ảnh";
            btnChooseImg.UseVisualStyleBackColor = true;
            btnChooseImg.Click += btnChooseImg_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(160, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 311);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnChooseImg);
            Controls.Add(picImage);
            Controls.Add(nudPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private NumericUpDown nudPrice;
        private PictureBox picImage;
        private Button btnChooseImg;
        private Button btnSave;
        private Button btnCancel;
    }
}