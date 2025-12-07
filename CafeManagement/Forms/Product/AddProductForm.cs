using CafeManagement.DAO;
using CafeManagement.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.Product
{
    public partial class AddProductForm : Form
    {
        private int categoryId;

        public AddProductForm()
        {
            InitializeComponent();
            categoryId = -1;
        }

        public AddProductForm(int cateId) : this()
        {
            categoryId = cateId;
        }

        // Public properties to allow other classes to prefill values
        public string ProductName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public decimal ProductPrice
        {
            get => nudPrice.Value;
            set => nudPrice.Value = value;
        }

        public Image ProductImage
        {
            get => picImage.Image;
            set => picImage.Image = value;
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên sản phẩm không được để trống");
                return;
            }

            if (picImage.Image == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh sản phẩm");
                return;
            }

            decimal price = nudPrice.Value;

            byte[] imgBytes = ImageHelper.ImageToBytes(picImage.Image);

            new ProductDAO().Insert(name, price, imgBytes, categoryId);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
