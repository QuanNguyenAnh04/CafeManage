using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class OrderDetailDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<OrderDetail> GetAllOrderDetails()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM OrderDetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orderDetails.Add(new OrderDetail
                    {
                        OrderDetailID = (int)reader["OrderDetailID"],
                        OrderID = (int)reader["OrderID"],
                        ProductID = (int)reader["ProductID"],
                        Amount = (int)reader["Amount"]
                    });
                }
            }

            return orderDetails;
        }

        // Thêm nhiều OrderDetail cho 1 OrderID
        public void AddOrderDetails(List<OrderDetail> orderDetails)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var od in orderDetails)
                {
                    string query = @"INSERT INTO OrderDetails (OrderID, ProductID, Amount)
                                     VALUES (@OrderID, @ProductID, @Amount)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", od.OrderID);
                        cmd.Parameters.AddWithValue("@ProductID", od.ProductID);
                        cmd.Parameters.AddWithValue("@Amount", od.Amount);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


    }
}
