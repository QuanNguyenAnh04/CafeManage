using CafeManagement.DAO;
using CafeManagement.Forms.Employee;
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

namespace CafeManagement.UserControls.Employee
{
    public partial class ucEmployee : UserControl
    {
        public Account CurrentUser { get; set; }
        public ucEmployee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        // ==========================
        // Load danh sách nhân viên
        // ==========================
        private void LoadAccounts()
        {
            flowEmployees.Controls.Clear();

            List<Account> accounts = AccountDAO.Instance.GetAllAccounts();

            foreach (var acc in accounts)
            {
                
                EmployeeCard card = new EmployeeCard();
                card.SetData(acc);

                // Gắn sự kiện Edit/Delete
                card.EditClicked += Card_EditClicked;
                card.DeleteClicked += Card_DeleteClicked;

                flowEmployees.Controls.Add(card);
                
            }
        }

        // ==========================
        // Nút Thêm mới
        // ==========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm frm = new AddEmployeeForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts(); // Load lại danh sách sau khi thêm
            }
        }

        // ==========================
        // Tìm kiếm nhân viên (tùy chọn)
        // ==========================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            flowEmployees.Controls.Clear();

            List<Account> accounts = AccountDAO.Instance.GetAllAccounts();

            foreach (var acc in accounts)
            {
                if (acc.DisplayName.ToLower().Contains(keyword) ||
                    acc.UserName.ToLower().Contains(keyword))
                {
                    EmployeeCard card = new EmployeeCard();
                    card.SetData(acc);
                    card.EditClicked += Card_EditClicked;
                    card.DeleteClicked += Card_DeleteClicked;
                    flowEmployees.Controls.Add(card);
                }
            }
        }

        // ==========================
        // Nút Sửa
        // ==========================
        private void Card_EditClicked(object sender, EventArgs e)
        {
            EmployeeCard card = sender as EmployeeCard;
            if (card == null) return;

            // Tạo form sửa nhân viên
            EditEmployeeForm frm = new EditEmployeeForm(card.Username);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts(); // Load lại sau khi sửa
            }
        }

        // ==========================
        // Nút Xóa
        // ==========================
        private void Card_DeleteClicked(object sender, EventArgs e)
        {
            EmployeeCard card = sender as EmployeeCard;
            if (card == null) return;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên {card.DisplayName}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool success = AccountDAO.Instance.DeleteAccount(card.Username);
                if (success)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại!");
                }
            }
        }

        public void ShowEmployeeList()
        {
            LoadAccounts();
        }



    }
}
