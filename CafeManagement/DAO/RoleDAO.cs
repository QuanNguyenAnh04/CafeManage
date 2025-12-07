using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class RoleDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; Integrated Security=True; TrustServerCertificate=True;";

        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roles.Add(new Role
                    {
                        RoleID = (int)reader["RoleID"],
                        RoleName = reader["RoleName"] as string ?? string.Empty
                    });
                }
            }

            return roles;
        }
    }
}
