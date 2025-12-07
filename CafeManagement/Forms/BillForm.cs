using CafeManagement.Models;
using CafeManagement.UserControls;
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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();

            // Tạo cột nếu chưa có
            if (dgvOrders.Columns.Count == 0)
            {
                dgvOrders.Columns.Add("STT", "STT");
                dgvOrders.Columns.Add("ProductName", "Tên sản phẩm");
                dgvOrders.Columns.Add("Quantity", "SL");
                dgvOrders.Columns.Add("TotalPrice", "Thành tiền");
            }

        }

        // Load dữ liệu hóa đơn
        public void LoadBill(Order order, List<OrderDetail> orderDetails, List<OrderItem> orderItems)
        {
            dgvOrders.Rows.Clear();

            lblTable.Text = "Bàn: " + order.TableID;
            lblDate.Text = "Ngày: " + order.CheckIn.ToString("dd/MM/yyyy HH:mm");

            int stt = 1;
            foreach (var item in orderItems)
            {
                if (item.Product != null)
                {
                    dgvOrders.Rows.Add(
                        stt,
                        item.Product.ProductName,
                        item.Quantity,
                        (item.Product.Price * item.Quantity).ToString("N0") + " VNĐ"
                    );
                    stt++;
                }
            }

            lblTotalPrice.Text = "Tổng: " + order.TotalPrice.ToString("N0") + " VNĐ";

            // Dãn form + DataGridView theo số hàng
            AdjustFormHeight();
        }


        private void AdjustFormHeight()
        {
            // Chiều cao một hàng
            int rowHeight = dgvOrders.RowTemplate.Height;

            // Số hàng
            int totalRows = dgvOrders.Rows.Count;

            // Chiều cao header + padding
            int extraHeight = dgvOrders.ColumnHeadersHeight + 50; // 50px cho padding

            // Cập nhật chiều cao DataGridView
            dgvOrders.Height = rowHeight * totalRows + extraHeight;

            // Dãn form theo DataGridView + padding
            this.Height = dgvOrders.Top + dgvOrders.Height + 100; // 100px padding phía dưới + lblTotalPrice + button
        }


        private void btnPrintBill_Click(object sender, EventArgs e)
        {

        }
    }
}
