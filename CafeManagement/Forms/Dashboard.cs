using CafeManagement.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms
{
    public partial class Dashboard : Form
    {
        private bool isLogout = false;
        private LoginForm? loginForm;

        private Button? currentButton = null; // Lưu button đang active
        private Account? account;

        public Dashboard(Account account, LoginForm login)
        {
            InitializeComponent();

            this.loginForm = login;
            this.FormClosed += Dashboard_FormClosed;

            // Mặc định khi vào Dashboard → btnRevenue active
            SetActiveButton(btnRevenue);
        }

        public Dashboard(Account account)
        {
            this.account = account;
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            splitContainerDashboard.Panel2.Controls.Clear();
            splitContainerDashboard.Panel2.Controls.Add(uc);
        }

        private void SetActiveButton(Button btn)
        {
            // Nếu click button đang active → không làm gì
            if (currentButton == btn)
                return;

            // Reset màu button cũ
            if (currentButton != null)
                currentButton.BackColor = Color.FromArgb(30, 30, 46);

            // Đổi màu button mới
            btn.BackColor = Color.DeepPink;
            currentButton = btn;
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    LoadUserControl(new ucCashier());
                }
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucRevenue());
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucInventory());
                }
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucStaff());
                }
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucStaff());
                }
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucStaff());
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Nếu button này đang active → không reload
                if (currentButton != btn)
                {
                    SetActiveButton(btn);
                    splitContainerDashboard.Panel2.Controls.Clear(); // xóa hết nội dung → rỗng
                    //LoadUserControl(new ucStaff());
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                isLogout = true;   // Đánh dấu là logout

                loginForm?.Show();   // mở lại form gốc
                this.Close();       // đóng Dashboard

                this.Close(); // Đóng Dashboard
            }
            else
            {
                // Không làm gì nếu người dùng chọn No
                return;
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit(); // Chỉ thoát chương trình nếu bấm X
            }
        }
    }
}
