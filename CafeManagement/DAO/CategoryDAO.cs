using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class CategoryDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        CategoryID = (int)reader["CategoryID"],
                        CategoryName = reader["CategoryName"] as string ?? string.Empty
                    });
                }
            }

            return categories;
        }
    }
}
