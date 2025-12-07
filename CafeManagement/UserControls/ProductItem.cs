using CafeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserControls
{
    public partial class ProductItem : UserControl
    {
        // AddClicked event declaration to fix CS0103
        public event EventHandler? AddClicked;

        public ProductItem()
        {
            InitializeComponent();
        }

        private Product? product;

        // Property để gán Product từ bên ngoài
        public Product? Product
        {
            get => product;
            set
            {
                product = value;
                UpdateUI();
            }
        }

        private async void UpdateUI()
        {
            if (product != null)
            {
                lbProductName.Text = product.ProductName;
                lbPrice.Text = product.Price.ToString("N0") + " đ";

                // ảnh mặc định trước
                imgProduct.Image = null;

                if (!string.IsNullOrEmpty(product.ImageURL))
                {
                    try
                    {
                        var bytes = await Task.Run(async () =>
                        {
                            using var httpClient = new HttpClient();
                            return await httpClient.GetByteArrayAsync(product.ImageURL);
                        });

                        using var ms = new System.IO.MemoryStream(bytes);
                        var img = Image.FromStream(ms);

                        // Set ảnh trên UI thread
                        imgProduct.Invoke((MethodInvoker)(() => imgProduct.Image = img));
                    }
                    catch
                    {
                        imgProduct.Invoke((MethodInvoker)(() => imgProduct.Image = null));
                    }
                }
            }
            else
            {
                lbProductName.Text = "Product";
                lbPrice.Text = "0";
                imgProduct.Image = null;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
