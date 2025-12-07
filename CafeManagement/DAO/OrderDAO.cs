using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class OrderDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderID = (int)reader["OrderID"],
                        CheckIn = (DateTime)reader["CheckIn"],
                        CheckOut = reader["CheckOut"] as DateTime?,
                        TableID = (int)reader["TableID"],
                        Discount = (int)reader["Discount"],
                        TotalPrice = (int)reader["TotalPrice"],
                        Status = (int)reader["Status"]
                    });
                }
            }

            return orders;
        }

        // Thêm Order mới, trả về OrderID vừa tạo
        public int AddOrder(Order order)
        {
            int orderId = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Orders (CheckIn, TableID, Discount, TotalPrice, Status)
                                 VALUES (@CheckIn, @TableID, @Discount, @TotalPrice, @Status);
                                 SELECT SCOPE_IDENTITY();"; // Lấy OrderID vừa tạo
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CheckIn", order.CheckIn);
                    cmd.Parameters.AddWithValue("@TableID", order.TableID);
                    cmd.Parameters.AddWithValue("@Discount", order.Discount);
                    cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                    cmd.Parameters.AddWithValue("@Status", order.Status);

                    orderId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return orderId;
        }

        // Cập nhật tổng tiền và trạng thái khi thanh toán xong
        public void UpdateOrder(int orderId, int totalPrice, int status = 1)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Orders 
                                 SET TotalPrice = @TotalPrice, Status = @Status, CheckOut = GETDATE()
                                 WHERE OrderID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
