using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Models;
using CafeManagement.DAO;
using CafeManagement.Forms.Product;

namespace CafeManagement.UserControls.Products
{
    public partial class ucCategoryItem : UserControl
    {
        private Category category;


        public event EventHandler<int> OnCategorySelected; // Truyền Id danh mục
        public event EventHandler OnCategoryDeleted;

        private CategoryDAO categoryDAO = new CategoryDAO();

        public ucCategoryItem(Category cate)
        {
            InitializeComponent();
            category = cate;
            lblName.Text = category.Name;
            this.CategoryId = category.Id; // ensure designer property is set
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Forms.Product.AddCategoryForm form = new Forms.Product.AddCategoryForm(category.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                category = categoryDAO.GetById(category.Id);
                lblName.Text = category.Name;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                categoryDAO.Delete(category.Id);
                OnCategoryDeleted?.Invoke(this, EventArgs.Empty);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            // set visual selected for this item; parent will unset others
            try
            {
                SetSelected(true);
            }
            catch { }

            OnCategorySelected?.Invoke(this, category.Id);
        }
    }
}
