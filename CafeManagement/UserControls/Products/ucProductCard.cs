using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.DAO;
using CafeManagement.Forms.Product;
using CafeManagement.UserControls.Products;
using CafeManagement.Models;
using CafeManagement.Helpers;
using System.IO;
using System.Net.Http;


namespace CafeManagement.UserControls.Products
{
    public partial class ucProductCard : UserControl
    {
        private Product product;
        public event EventHandler OnEditClick;
        public event EventHandler OnProductDeleted;

        public ucProductCard(Product prod)
        {
            InitializeComponent();
            product = prod;
            LoadData();
        }

        private void LoadData()
        {
            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C");

            picImage.Image = null;

            // First try explicit byte[] in Product.Image
            try
            {
                if (product.Image != null && product.Image.Length > 0)
                {
                    picImage.Image = ImageHelper.BytesToImage(product.Image);
                    return;
                }
            }
            catch
            {
                // ignore and try other methods
            }

            // If ImageURL is available, handle base64, local file or http(s) URL
            if (!string.IsNullOrEmpty(product.ImageURL))
            {
                // Try base64
                try
                {
                    // Heuristic: if string length is large enough try base64 decode
                    if (product.ImageURL.Length > 100)
                    {
                        var bytes = Convert.FromBase64String(product.ImageURL);
                        picImage.Image = ImageHelper.BytesToImage(bytes);
                        return;
                    }
                }
                catch
                {
                    // not base64
                }

                // Try local file
                try
                {
                    if (File.Exists(product.ImageURL))
                    {
                        picImage.Image = Image.FromFile(product.ImageURL);
                        return;
                    }
                }
                catch
                {
                    // ignore
                }

                // Try HTTP(s)
                try
                {
                    if (Uri.IsWellFormedUriString(product.ImageURL, UriKind.Absolute))
                    {
                        // async download without blocking UI
                        Task.Run(async () =>
                        {
                            try
                            {
                                using var http = new HttpClient();
                                var bytes = await http.GetByteArrayAsync(product.ImageURL);
                                using var ms = new MemoryStream(bytes);
                                var img = Image.FromStream(ms);
                                picImage.Invoke((MethodInvoker)(() => picImage.Image = img));
                            }
                            catch
                            {
                                // ignore download errors
                            }
                        });
                        return;
                    }
                }
                catch
                {
                    // ignore
                }
            }

            // fallback: leave image null
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(product.CategoryId);
            form.ProductName = product.Name;
            form.ProductPrice = product.Price;
            // do not set image bytes here

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Load lại dữ liệu sau khi sửa
                var updated = new ProductDAO().GetById(product.Id);
                if (updated != null)
                {
                    product = updated;
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                new ProductDAO().Delete(product.Id);
                OnProductDeleted?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
