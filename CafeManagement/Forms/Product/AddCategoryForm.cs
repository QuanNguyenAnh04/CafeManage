using CafeManagement.DAO;
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
    public partial class AddCategoryForm : Form
    {
        private int editId = -1; // -1 là thêm mới, >=0 là chỉnh sửa
        private CategoryDAO categoryDAO = new CategoryDAO();

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        public AddCategoryForm( int id) :this()
        {
            editId = id;
            var cate = categoryDAO.GetById(id);
            txtName.Text = cate.Name;
            lblTitle.Text = "Chỉnh sửa danh mục";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên danh mục không được để trống");
                return;
            }

            if (editId == -1)
            {
                categoryDAO.Insert(name);
            }
            else
            {
                categoryDAO.Update(editId, name);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
