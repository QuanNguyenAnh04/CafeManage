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
using System.Drawing.Drawing2D;

namespace CafeManagement.UserControls.Employee
{
    public partial class EmployeeCard : UserControl
    {

        public string Username { get; private set; }
        public string DisplayName { get; private set; }
        public int RoleID { get; private set; }

        // Event cho nút Edit/ Delete
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public EmployeeCard()
        {
            InitializeComponent();

            MakeAvatarRound();
            // Optional: tạo avatar tròn
        }

        private void MakeAvatarRound()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, picAvatar.Width - 1, picAvatar.Height - 1);
            picAvatar.Region = new Region(gp);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Set dữ liệu cho thẻ từ Account
        public void SetData(Account acc)
        {
            Username = acc.UserName;
            DisplayName = acc.DisplayName;
            RoleID = acc.RoleID;

            lblName.Text = DisplayName;
            lblUsername.Text = "@" + Username;

            if (RoleID == 1)
            {
                lblRole.Text = "Admin";
                lblRole.BackColor = Color.Purple;
            }
            else
            {
                lblRole.Text = "Nhân viên";
                lblRole.BackColor = Color.Blue;
            }
            picAvatar.Image = Properties.Resources.user_avatar;
            // Optional: thay đổi avatar nếu có
            // picAvatar.Image = ...
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
