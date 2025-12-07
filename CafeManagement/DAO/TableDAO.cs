using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class TableDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<Table> GetAllTables()
        {
            List<Table> tables = new List<Table>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TableCafe";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tables.Add(new Table
                    {
                        TableID = (int)reader["TableID"],
                        TableName = reader["TableName"] as string ?? string.Empty,
                        Status = (bool)reader["Status"]
                    });
                }
            }

            return tables;
        }
    }
}
