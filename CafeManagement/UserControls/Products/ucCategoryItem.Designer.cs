namespace CafeManagement.UserControls.Products
{
    partial class ucCategoryItem
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

        public int CategoryId { get; set; }

        public void SetCategory(string name, int id)
        {
            lblName.Text = name;
            CategoryId = id;
        }

        public void SetSelected(bool selected)
        {
            if (selected)
            {
                panelMain.BackColor = Color.FromArgb(138, 43, 226);
                lblName.ForeColor = Color.White;
            }
            else
            {
                panelMain.BackColor = Color.FromArgb(244,245,250);
                lblName.ForeColor = Color.Black;
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCategoryItem));
            panelMain = new Panel();
            picDelete = new PictureBox();
            picEdit = new PictureBox();
            lblName = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 245, 250);
            panelMain.Controls.Add(picDelete);
            panelMain.Controls.Add(picEdit);
            panelMain.Controls.Add(lblName);
            panelMain.Cursor = Cursors.Hand;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(260, 45);
            panelMain.TabIndex = 0;
            panelMain.Click += lblName_Click;
            // 
            // picDelete
            // 
            picDelete.Image = (Image)resources.GetObject("picDelete.Image");
            picDelete.Location = new Point(230, 12);
            picDelete.Name = "picDelete";
            picDelete.Size = new Size(20, 20);
            picDelete.SizeMode = PictureBoxSizeMode.Zoom;
            picDelete.TabIndex = 2;
            picDelete.TabStop = false;
            picDelete.Click += btnDelete_Click;
            // 
            // picEdit
            // 
            picEdit.Image = (Image)resources.GetObject("picEdit.Image");
            picEdit.Location = new Point(200, 12);
            picEdit.Name = "picEdit";
            picEdit.Size = new Size(20, 20);
            picEdit.SizeMode = PictureBoxSizeMode.Zoom;
            picEdit.TabIndex = 1;
            picEdit.TabStop = false;
            picEdit.Click += btnEdit_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(15, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Tên danh mục";
            // 
            // ucCategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelMain);
            Margin = new Padding(5);
            Name = "ucCategoryItem";
            Size = new Size(260, 45);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private PictureBox picDelete;
        private PictureBox picEdit;
        private Label lblName;
    }
}
