using CafeManagement.DAO;
using CafeManagement.Models;
using CafeManagement.UserControls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Table = CafeManagement.Models.Table;

namespace CafeManagement.Forms
{
    public partial class ucCashier : UserControl
    {
        private ProductDAO productDAO = new ProductDAO();
        private TableDAO tableDAO = new TableDAO();
        private CategoryDAO categoryDAO = new CategoryDAO();

        private List<OrderItem> orderList = new List<OrderItem>();

        private string currentSearchKeyword = ""; // Từ khóa tìm kiếm hiện tại
        private int? currentCategoryId = null; // Danh mục hiện tại, có thể là null nếu không chọn danh mục

        private Button? selectedTable = null; // Lưu bàn đang chọn
        private Button? selectedCategory = null; // lưu danh mục đang chọn

        // Add this field to store the connection string
        private readonly string connectionString = "your_connection_string_here";

        public ucCashier()
        {
            InitializeComponent();

            LoadTables();       // Load bàn
            LoadCategories();   // Load danh mục (mặc định All)
            LoadProducts();     // Load tất cả sản phẩm

            numDiscount.ValueChanged += (s, e) => UpdateTotalPrice();

        }

        private void LoadTables()
        {
            panelTables.Controls.Clear(); // Xóa các item cũ trong panelTables
            panelTables.AutoScroll = true;
            panelTables.FlowDirection = FlowDirection.LeftToRight; // Hiển thị các button theo chiều ngang
            panelTables.WrapContents = true; // Cho phép xuống dòng khi không đủ chỗ

            List<Table> tables = tableDAO.GetAllTables(); // Lấy tất cả bàn từ database

            foreach (var table in tables)
            {
                Button btnTable = new Button
                {
                    Text = table.TableName,
                    Width = 95,
                    Height = 95,
                    Margin = new Padding(12),
                    FlatStyle = FlatStyle.Flat, // Sử dụng phong cách phẳng để loại bỏ hiệu ứng 3D
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray }, // Viền đơn giản với màu xám
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Dock = DockStyle.None
                };

                // Màu mặc định (Trống = trắng, có khách = đỏ)
                btnTable.BackColor = table.Status ? Color.White : Color.Red;

                // Sự kiện click khi chọn bàn
                btnTable.Click += (s, e) =>
                {
                    if (s is Button clickedButton)
                    {
                        // Reset màu bàn trước đó nếu có
                        if (selectedTable != null)
                        {
                            // Lấy dữ liệu bàn từ Tag để reset màu lại (trạng thái cũ)
                            var prevTable = selectedTable.Tag as Table;
                            selectedTable.BackColor = prevTable?.Status == true ? Color.White : Color.Red;
                        }

                        // Đổi màu bàn vừa click sang xanh (đang chọn)
                        clickedButton.BackColor = Color.LightBlue;

                        // Lưu bàn vừa chọn vào Tag để quản lý trạng thái bàn (trạng thái cũ)
                        clickedButton.Tag = table;
                        selectedTable = clickedButton;

                        // Cập nhật lblTitleTable
                        lblTitleTable.Text = table.TableName;
                    }
                };

                // Lưu bàn vào Tag để khi cần reset lại màu sắc
                btnTable.Tag = table;

                // Thêm button vào panelTables
                panelTables.Controls.Add(btnTable);
            }
        }

        private void LoadCategories()
        {
            panelCategories.Controls.Clear(); // Xóa các item cũ trong panelCategories
            panelCategories.AutoScroll = true; // Cho phép cuộn khi vượt quá kích thước
            panelCategories.FlowDirection = FlowDirection.LeftToRight; // Hiển thị các button theo chiều ngang
            panelCategories.WrapContents = true; // Cho phép xuống dòng khi không đủ chỗ

            // Button "Tất cả" để hiển thị tất cả sản phẩm
            Button btnAll = new Button
            {
                Text = "Tất cả",
                Width = 100,
                Height = 40,
                Margin = new Padding(10),
                BackColor = Color.LightBlue, // Màu mặc định cho "Tất cả"
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray },
                Dock = DockStyle.None
            };

            selectedCategory = btnAll; // Mặc định chọn "Tất cả" khi load lần đầu

            // Sự kiện khi chọn "Tất cả"
            btnAll.Click += (s, e) =>
            {
                if (selectedCategory != null) selectedCategory.BackColor = Color.White; // Reset màu cũ
                btnAll.BackColor = Color.LightBlue; // Màu xanh cho button đang chọn
                selectedCategory = btnAll;
                LoadProducts(); // Load tất cả sản phẩm
            };
            panelCategories.Controls.Add(btnAll);

            // Load danh mục từ database
            List<Category> categories = categoryDAO.GetAllCategories();

            foreach (var cat in categories)
            {
                Button btn = new Button
                {
                    Text = cat.CategoryName,
                    Width = 100,
                    Height = 40,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray },
                    Tag = cat,
                    Dock = DockStyle.None
                };

                // Sự kiện click vào button danh mục
                btn.Click += (s, e) =>
                {
                    if (selectedCategory != null) selectedCategory.BackColor = Color.White; // Reset màu cũ
                    btn.BackColor = Color.LightBlue; // Màu xanh cho button đang chọn
                    selectedCategory = btn;

                    if (btn.Tag is Category selectedCat)
                    {
                        LoadProducts(selectedCat.CategoryID); // Load sản phẩm theo danh mục
                    }
                };

                panelCategories.Controls.Add(btn);
            }

            // SEARCH BOX
            searchBox.TextChanged += (s, e) =>
            {
                // Khi có sự thay đổi trong ô tìm kiếm, gọi phương thức SearchProducts
                SearchProducts(searchBox.Text);
            };
        }

        // Load sản phẩm theo category (gọi RefreshProducts)
        private void LoadProducts(int? categoryId = null)
        {
            currentCategoryId = categoryId; // Lưu category đang chọn
            RefreshProducts(); // Load theo category + từ khóa hiện tại
        }

        // Search sản phẩm
        public void SearchProducts(string keyword)
        {
            currentSearchKeyword = keyword; // Lưu từ khóa
            RefreshProducts(); // Load theo category + từ khóa hiện tại
        }

        // QUẢN LÝ ORDER
        private void AddToOrder(Product product)
        {
            var existing = orderList.FirstOrDefault(o => o.Product != null && o.Product.ProductID == product.ProductID);

            if (existing != null)
            {
                existing.Quantity += 1; // Tăng số lượng nếu đã có
                UpdateTotalPrice();
                return;
            }

            // Nếu chưa có, tạo OrderItem mới
            OrderItem newItem = new OrderItem
            {
                Product = product,
                Quantity = 1
            };

            // Khi bấm nút xóa trong OrderItem
            newItem.Removed += (s, e) =>
            {
                orderList.Remove(newItem);
                panelOrders.Controls.Remove(newItem);
                UpdateTotalPrice();
            };

            // Khi tăng giảm số lượng trong OrderItem
            newItem.QuantityChanged += (s, e) =>
            {
                UpdateTotalPrice();
            };

            orderList.Add(newItem);
            panelOrders.Controls.Add(newItem);
            UpdateTotalPrice();
        }

        // REFRESH SẢN PHẨM (category + search)
        private void RefreshProducts()
        {
            panelProducts.Controls.Clear();
            panelProducts.AutoScroll = true;
            panelProducts.WrapContents = true;
            panelProducts.FlowDirection = FlowDirection.LeftToRight;

            List<Product> products;

            // Lấy sản phẩm theo category đang chọn
            if (currentCategoryId.HasValue)
                products = productDAO.GetProductsByCategory(currentCategoryId.Value);
            else
                products = productDAO.GetAllProducts();

            // Lọc theo từ khóa tìm kiếm
            if (!string.IsNullOrWhiteSpace(currentSearchKeyword))
            {
                string k = currentSearchKeyword.ToLower();
                products = products.Where(p => p.ProductName.ToLower().Contains(k)).ToList();
            }

            foreach (var p in products)
            {
                ProductItem item = new ProductItem
                {
                    Product = p,
                    Width = 150,
                    Height = 200,
                    Margin = new Padding(10)
                };
                item.AddClicked += (s, e) => AddToOrder(p);
                panelProducts.Controls.Add(item);
            }
        }

        private void UpdateTotalPrice()
        {
            if (orderList.Count == 0)
            {
                lblTmpTotalPrice.Text = "0 VNĐ";
                lblTotalPrice.Text = "0 VNĐ";
                return;
            }

            decimal total = orderList
                .Where(o => o.Product != null)
                .Sum(o => o.Product!.Price * o.Quantity); // giả sử Price là decimal

            // Hiển thị giá gốc
            lblTmpTotalPrice.Text = $"{total:N0} VNĐ";

            // Áp dụng discount (decimal)
            decimal discountPercent = numDiscount.Value; // giữ decimal
            decimal totalAfterDiscount = total - (total * discountPercent / 100);

            lblTotalPrice.Text = $"{totalAfterDiscount:N0} VNĐ";
        }

        // THANH TOÁN
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (orderList.Count == 0)
            {
                MessageBox.Show("Danh sách order trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var table = selectedTable.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bàn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tableId = table.TableID;

            // 1. Tính tổng tiền
            decimal total = orderList
                .Where(o => o.Product != null)
                .Sum(o => o.Product!.Price * o.Quantity);

            // 2. Thêm Order vào database (Status = 0 tạm thời)
            Order order = new Order
            {
                TableID = tableId,
                TotalPrice = (int)total,
                CheckIn = DateTime.Now,
                Status = 0
            };
            int orderId = new OrderDAO().AddOrder(order);

            // 3. Thêm OrderDetails vào database
            List<OrderDetail> details = orderList
                .Where(o => o.Product != null)
                .Select(o => new OrderDetail
                {
                    OrderID = orderId,
                    ProductID = o.Product!.ProductID,
                    Amount = o.Quantity
                }).ToList();
            new OrderDetailDAO().AddOrderDetails(details);

            // 4. Cập nhật Order: thanh toán xong, Status = 1, CheckOut = now
            new OrderDAO().UpdateOrder(orderId, (int)total, 1);

            MessageBox.Show("Thanh toán hoàn tất!");

            // 5. Hiển thị hóa đơn
            BillForm billForm = new BillForm();
            billForm.LoadBill(order, details, orderList);
            billForm.ShowDialog();

            // 6. Reset orderList + panelOrders
            orderList.Clear();
            panelOrders.Controls.Clear();

            // 7. Reset màu bàn
            selectedTable.BackColor = table.Status ? Color.White : Color.Red;
            selectedTable = null;
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {

        }

    }
}
