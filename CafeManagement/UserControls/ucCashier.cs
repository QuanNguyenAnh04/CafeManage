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

        private string currentSearchKeyword = ""; // Từ khóa tìm kiếm hiện tại
        private int? currentCategoryId = null; // Danh mục hiện tại, có thể là null nếu không chọn danh mục

        private Button? selectedTable = null; // Lưu bàn đang chọn
        private Button? selectedCategory = null; // lưu danh mục đang chọn

        // Add this field to store the connection string
        private readonly string connectionString = "your_connection_string_here";

        public ucCashier()
        {
            InitializeComponent();

            LoadTables();
            LoadCategories();
            LoadProducts();
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
                    Width = 80,
                    Height = 80,
                    Margin = new Padding(10),
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

                        // Thông báo khi chọn bàn
                        MessageBox.Show("Bạn chọn bàn: " + table.TableName);
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
            panelCategories.AutoScroll = true; // Cho phép scroll khi vượt quá kích thước
            panelCategories.FlowDirection = FlowDirection.LeftToRight; // Hiển thị các button theo chiều ngang
            panelCategories.WrapContents = false; // Cho phép xuống dòng khi không đủ chỗ

            // Tạo nút "Tất cả" để hiển thị tất cả sản phẩm
            Button btnAll = new Button
            {
                Text = "Tất cả",
                Width = 100,
                Height = 40, // Chiều cao của button
                Margin = new Padding(10),
                BackColor = Color.LightBlue, // Màu mặc định cho "Tất cả"
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray },
                AutoSize = false,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Dock = DockStyle.None
            };

            selectedCategory = btnAll; // Mặc định chọn "Tất cả" khi load lần đầu

            // Sự kiện khi chọn "Tất cả"
            btnAll.Click += (s, e) =>
            {
                // Đổi màu cho button "Tất cả"
                if (this.selectedCategory != null)
                {
                    this.selectedCategory.BackColor = Color.White;
                }

                btnAll.BackColor = Color.LightBlue;
                this.selectedCategory = btnAll; // Lưu lại button đang chọn

                // Load tất cả sản phẩm khi chọn "Tất cả"
                LoadProducts();
            };

            // Thêm button "Tất cả" vào panel
            panelCategories.Controls.Add(btnAll);

            // Lấy danh mục từ cơ sở dữ liệu thông qua CategoryDAO
            List<Category> categories = categoryDAO.GetAllCategories();

            // Tạo danh sách button danh mục
            foreach (var category in categories)
            {
                Button btnCategory = new Button
                {
                    Text = category.CategoryName,
                    Width = 100,
                    Height = 40, // Chiều cao của button
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat, // Sử dụng phong cách phẳng để loại bỏ hiệu ứng 3D
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray },
                    AutoSize = false,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Dock = DockStyle.None
                };

                // Lưu thông tin về Category vào Tag của Button
                btnCategory.Tag = category;

                // Sự kiện click vào button danh mục
                btnCategory.Click += (s, e) =>
                {
                    if (s is Button clickedButton)
                    {
                        // Reset màu cho button trước đó nếu có
                        if (this.selectedCategory != null)
                        {
                            this.selectedCategory.BackColor = Color.White;
                        }

                        // Đổi màu cho button được chọn
                        clickedButton.BackColor = Color.LightBlue; // Màu xanh cho button đang được chọn
                        this.selectedCategory = clickedButton; // Lưu lại button đang chọn

                        // Lấy thông tin từ Tag (danh mục đã chọn)
                        if (clickedButton.Tag is Category selectedCat)
                        {
                            MessageBox.Show("Bạn đã chọn danh mục: " + selectedCat.CategoryName);
                            // Load sản phẩm theo danh mục đã chọn
                            LoadProductsByCategory(selectedCat.CategoryID);
                        }
                    }
                };

                panelCategories.Controls.Add(btnCategory);
            }

            // Thêm ô tìm kiếm sản phẩm vào panelCategories (ở cuối các button category)
            TextBox searchBox = new TextBox
            {
                Width = 220,
                Height = 40,
                Margin = new Padding(10),
                PlaceholderText = "Tìm kiếm sản phẩm...", // Placeholder để chỉ rõ người dùng có thể tìm kiếm
                AutoSize = false,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Dock = DockStyle.None,
            };

            searchBox.TextChanged += (s, e) =>
            {
                // Khi có sự thay đổi trong ô tìm kiếm, gọi phương thức LoadProducts để lọc sản phẩm
                LoadProductsBySearch(searchBox.Text);
            };

            // Thêm TextBox vào cuối panelCategories
            panelCategories.Controls.Add(searchBox);
        }

        // Phương thức để load sản phẩm theo từ khóa tìm kiếm
        private void LoadProductsBySearch(string searchKeyword)
        {
            // Xóa các item cũ trong panelProducts
            panelProducts.Controls.Clear();
            panelProducts.AutoScroll = true; // Cho phép scroll
            panelProducts.WrapContents = true; // xuống dòng khi hết chỗ
            panelProducts.FlowDirection = FlowDirection.LeftToRight;

            // Lấy danh sách sản phẩm dựa trên tên tìm kiếm
            List<CafeManagement.Models.Product> products = productDAO.GetProductsByName(searchKeyword);

            foreach (var product in products)
            {
                ProductItem item = new ProductItem();
                item.Product = product;
                item.Width = 150;
                item.Height = 200;
                item.Margin = new Padding(10); // khoảng cách giữa các item

                // Thêm sự kiện AddClicked vào ProductItem
                item.AddClicked += (s, e) =>
                {
                    if (s is ProductItem clickedItem && clickedItem.Product != null)
                    {
                        MessageBox.Show($"Thêm {product.ProductName} vào giỏ hàng");
                    }
                };

                panelProducts.Controls.Add(item);
            }
        }

        // Cập nhật phương thức LoadProductsByCategory để load sản phẩm theo category
        private void LoadProductsByCategory(int categoryId)
        {
            // Xóa các item cũ trong panelProducts
            panelProducts.Controls.Clear();
            panelProducts.AutoScroll = true;
            panelProducts.WrapContents = true;
            panelProducts.FlowDirection = FlowDirection.LeftToRight;

            // Lấy danh sách sản phẩm theo categoryId
            List<CafeManagement.Models.Product> products = productDAO.GetProductsByCategory(categoryId);

            foreach (var product in products)
            {
                ProductItem item = new ProductItem();
                item.Product = product;
                item.Width = 150;
                item.Height = 200;
                item.Margin = new Padding(10);

                // Thêm sự kiện AddClicked vào ProductItem
                item.AddClicked += (s, e) =>
                {
                    if (s is ProductItem clickedItem && clickedItem.Product != null)
                    {
                        MessageBox.Show($"Thêm {product.ProductName} vào giỏ hàng");
                    }
                };

                panelProducts.Controls.Add(item);
            }
        }

        private void LoadProducts()
        {
            // Xóa các item cũ trong panelProducts
            panelProducts.Controls.Clear();
            panelProducts.AutoScroll = true; // Cho phép scroll
            panelProducts.WrapContents = true; // xuống dòng khi hết chỗ
            panelProducts.FlowDirection = FlowDirection.LeftToRight;

            List<CafeManagement.Models.Product> products = productDAO.GetAllProducts();

            foreach (var product in products)
            {
                ProductItem item = new ProductItem();
                item.Product = product;
                item.Width = 150;
                item.Height = 200;
                item.Margin = new Padding(10); // khoảng cách giữa các item

                // Thêm sự kiện AddClicked vào ProductItem
                item.AddClicked += (s, e) =>
                {
                    if (s is ProductItem clickedItem && clickedItem.Product != null)
                    {
                        MessageBox.Show($"Thêm {product.ProductName} vào giỏ hàng");
                    }
                };

                panelProducts.Controls.Add(item);
            }
        }
    }

}
