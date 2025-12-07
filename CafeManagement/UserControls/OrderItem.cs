using CafeManagement.Models;
using System;
using System.Windows.Forms;

namespace CafeManagement.UserControls
{
    public partial class OrderItem : UserControl
    {
        private Product? product;

        public Product? Product
        {
            get => product;
            set
            {
                product = value;

                if (product != null)
                {
                    // Hiển thị tên sản phẩm
                    lblProductName.Text = product.ProductName;

                    // Hiển thị giá
                    lblPrice.Text = product.Price.ToString("N0") + " VND";

                    // Load ảnh sản phẩm từ URL
                    if (!string.IsNullOrEmpty(product.ImageURL))
                    {
                        try
                        {
                            imgProduct.SizeMode = PictureBoxSizeMode.Zoom;  // tránh méo ảnh
                            imgProduct.LoadAsync(product.ImageURL);       // Load ảnh URL không treo UI
                        }
                        catch
                        {
                            imgProduct.Image = null; // tránh crash nếu lỗi
                        }
                    }
                    else
                    {
                        imgProduct.Image = null;
                    }
                }
            }
        }

        private int quantity = 1;
        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                tbAmount.Text = quantity.ToString(); // cập nhật textbox hiển thị số lượng
            }
        }

        public event EventHandler? Removed;
        public event EventHandler? QuantityChanged;

        public OrderItem()
        {
            InitializeComponent();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Removed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Quantity++;
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
