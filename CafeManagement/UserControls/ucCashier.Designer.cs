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
            panelCategories = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Size = new Size(626, 369);
            splitContainer1.SplitterDistance = 316;
            splitContainer1.SplitterWidth = 22;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer2.Panel2.Controls.Add(panelCategories);
            splitContainer2.Size = new Size(316, 369);
            splitContainer2.SplitterDistance = 112;
            splitContainer2.SplitterWidth = 19;
            splitContainer2.TabIndex = 0;
            // 
            // panelTables
            // 
            panelTables.Dock = DockStyle.Fill;
            panelTables.Location = new Point(0, 55);
            panelTables.Margin = new Padding(3, 2, 3, 2);
            panelTables.Name = "panelTables";
            panelTables.Size = new Size(316, 57);
            panelTables.TabIndex = 1;
            // 
            // lbTable
            // 
            lbTable.Dock = DockStyle.Top;
            lbTable.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTable.Location = new Point(0, 0);
            lbTable.Name = "lbTable";
            lbTable.Padding = new Padding(22, 0, 0, 0);
            lbTable.Size = new Size(316, 55);
            lbTable.TabIndex = 0;
            lbTable.Text = "Sơ đồ bàn";
            lbTable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelProducts
            // 
            panelProducts.Dock = DockStyle.Fill;
            panelProducts.Location = new Point(0, 69);
            panelProducts.Margin = new Padding(3, 2, 3, 2);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(316, 169);
            panelProducts.TabIndex = 1;
            // 
            // panelCategories
            // 
            panelCategories.Dock = DockStyle.Top;
            panelCategories.Location = new Point(0, 0);
            panelCategories.Margin = new Padding(3, 2, 3, 2);
            panelCategories.Name = "panelCategories";
            panelCategories.Size = new Size(316, 69);
            panelCategories.TabIndex = 0;
            // 
            // ucCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucCashier";
            Size = new Size(626, 369);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel panelProducts;
        private FlowLayoutPanel panelCategories;
        private FlowLayoutPanel panelTables;
        private Label lbTable;
    }
}
