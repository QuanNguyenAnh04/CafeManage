using CafeManagement.DAO;
using CafeManagement.Forms;
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

namespace CafeManagement
{
    public partial class LoginForm : Form
    {
        public event Action<Account>? LoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // Căn panel luôn nằm giữa form
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Checkbox được tick → hiển thị mật khẩu thật
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Checkbox bỏ tick → ẩn mật khẩu bằng chấm hệ thống
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account? account = AccountDAO.Instance.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (account != null)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard(account, this);

                dashboard.Show();  // mở dạng non-modal
                this.Hide();       // ẩn LoginForm nhưng KHÔNG quay lại nữa
            }
            else
            {
                MessageBox.Show(
                    "Sai tên đăng nhập hoặc mật khẩu!",
                    "Lỗi đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }

}
