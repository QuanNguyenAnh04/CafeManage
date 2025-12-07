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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Tải danh sách vai trò
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Nhân viên");  // RoleID = 2
            cmbRole.Items.Add("Quản trị");   // RoleID = 1
            cmbRole.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullname = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem.ToString();

            // Kiểm tra nhập đủ
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Xác định RoleID (KHỚP VỚI DATABASE CỦA BẠN)
            int roleId = 2; // Mặc định nhân viên
            if (selectedRole == "Quản trị")
            {
                roleId = 1;
            }

            // Gọi DAO thêm vào database
            bool success = AccountDAO.Instance.CreateAccount(username, fullname, password, roleId);

            if (success)
            {
                MessageBox.Show("Tạo tài khoản thành công!",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Trả kết quả về UC_Employee
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại hoặc lỗi khi tạo tài khoản!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
