using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class AccountDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Accounts";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    accounts.Add(new Account
                    {
                        UserName = reader["UserName"] as string ?? string.Empty,
                        DisplayName = reader["DisplayName"] as string ?? string.Empty,
                        Password = reader["Password"] as string ?? string.Empty,
                        RoleID = (int)reader["RoleID"]
                    });
                }
            }

            return accounts;
        }

        public Account? CheckLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Accounts WHERE UserName = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Nếu có kết quả → đăng nhập đúng
                    return new Account
                    {
                        UserName = reader["UserName"] as string ?? string.Empty,
                        DisplayName = reader["DisplayName"] as string ?? string.Empty,
                        Password = reader["Password"] as string ?? string.Empty,
                        RoleID = (int)reader["RoleID"]
                    };
                }
                else
                {
                    return null; // Sai thông tin
                }
            }
        }

    }
}
