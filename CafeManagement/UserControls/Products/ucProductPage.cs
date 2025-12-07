using CafeManagement.DAO;
using CafeManagement.Forms.Product;
using CafeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserControls.Products
{
    public partial class ucProductPage : UserControl
    {
        private int currentCategoryId = -1;


        public ucProductPage()
        {
            InitializeComponent();
            LoadCategories();

        }


        public void LoadCategories()
        {
            flowCategory.Controls.Clear();
            var categories = new CategoryDAO().GetAllCategories();
            foreach (var c in categories)
            {
                var ucCate = new ucCategoryItem(c);
                // When a category is selected, clear selection on others, set this selected, and load products
                ucCate.OnCategorySelected += (s, categoryId) =>
                {
                    // Clear previous selection visuals
                    foreach (Control ctrl in flowCategory.Controls)
                    {
                        if (ctrl is ucCategoryItem item)
                            item.SetSelected(false);
                    }

                    // Set visual for clicked item
                    if (s is ucCategoryItem clickedItem)
                        clickedItem.SetSelected(true);

                    currentCategoryId = categoryId;
                    LoadProducts(categoryId);
                };

                ucCate.OnCategoryDeleted += (s,e) => LoadCategories();
                flowCategory.Controls.Add(ucCate);
            }

            // Optionally select the first category if any
            if (flowCategory.Controls.Count > 0)
            {
                if (flowCategory.Controls[0] is ucCategoryItem first)
                {
                    // simulate selection
                    first.SetSelected(true);
                    currentCategoryId = first.CategoryId;
                    LoadProducts(currentCategoryId);
                }
            }
        }
        private void ucCate_OncategorySelected(object sender, int categoryId)
        {
            // kept for compatibility but not used; left empty
        }
        public void LoadProducts(int categoryId)
        {
            flowProduct.Controls.Clear();
            var products = new ProductDAO().GetProductsByCategory(categoryId);
            foreach (var p in products)
            {
                var ucProduct = new ucProductCard(p);
                ucProduct.OnProductDeleted += (s, e) => LoadProducts(currentCategoryId);
                flowProduct.Controls.Add(ucProduct);
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var form = new AddCategoryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (currentCategoryId == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục trước!");
                return;
            }

            var form = new AddProductForm(currentCategoryId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts(currentCategoryId);
            }

        }
        
    }
}
