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
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        private AccountDAO() { }
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

        // ===========================
        // KIỂM TRA USERNAME TRÙNG
        // ===========================
        private bool UsernameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Accounts WHERE UserName = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        // ===========================
        // TẠO TÀI KHOẢN MỚI
        // ===========================
        public bool CreateAccount(string username, string fullname, string password, int roleId)
        {
            if (UsernameExists(username))
                return false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Accounts(UserName, DisplayName, Password, RoleID)
                             VALUES(@username, @fullname, @password, @roleId)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@roleId", roleId);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        // ===========================
        // XÓA TÀI KHOẢN
        // ===========================

        public bool DeleteAccount(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Accounts WHERE UserName=@username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Lấy account theo username
        public Account GetAccountByUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Accounts WHERE UserName=@username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Account
                    {
                        UserName = reader["UserName"].ToString(),
                        DisplayName = reader["DisplayName"].ToString(),
                        Password = reader["Password"].ToString(),
                        RoleID = (int)reader["RoleID"]
                    };
                }
                return null;
            }
        }

        // Cập nhật account
        public bool UpdateAccount(string username, string displayName, string password, int roleId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query;
                if (string.IsNullOrEmpty(password))
                {
                    // Không thay đổi mật khẩu
                    query = "UPDATE Accounts SET DisplayName=@displayName, RoleID=@roleId WHERE UserName=@username";
                }
                else
                {
                    query = "UPDATE Accounts SET DisplayName=@displayName, Password=@password, RoleID=@roleId WHERE UserName=@username";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@displayName", displayName);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                if (!string.IsNullOrEmpty(password))
                    cmd.Parameters.AddWithValue("@password", password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
