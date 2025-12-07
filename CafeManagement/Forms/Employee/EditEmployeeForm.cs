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

namespace CafeManagement.Forms.Employee
{
    public partial class EditEmployeeForm : Form
    {
        private string username;
        public EditEmployeeForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // Load dữ liệu nhân viên từ DAO
            var account = AccountDAO.Instance.GetAccountByUsername(username);
            if (account == null)
            {
                MessageBox.Show("Nhân viên không tồn tại!");
                this.Close();
                return;
            }

            txtUsername.Text = account.UserName;
            txtFullName.Text = account.DisplayName;
            txtPassword.Text = ""; // rỗng = giữ nguyên mật khẩu

            // Load role
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Nhân viên"); // RoleID=2
            cmbRole.Items.Add("Admin");      // RoleID=1
            cmbRole.SelectedIndex = account.RoleID == 1 ? 1 : 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            int roleId = cmbRole.SelectedItem.ToString() == "Admin" ? 1 : 2;

            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Tên hiển thị không được để trống!");
                return;
            }

            bool success = AccountDAO.Instance.UpdateAccount(username, fullname, password, roleId);

            if (success)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
