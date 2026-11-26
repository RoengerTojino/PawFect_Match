using System;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class UserRepository
    {
        public bool UsernameExists(string username)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query =
                    "SELECT COUNT(1) FROM tbl_Users WHERE Username = @Username";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.VarChar, 50).Value = username;

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public bool EmailExists(string email)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query =
                    "SELECT COUNT(1) FROM tbl_Users WHERE Email = @Email";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Email", SqlDbType.VarChar, 150).Value = email;

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public UserAccount GetUserByUsername(string username)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query =
                    @"SELECT UserID, Username, Email, PasswordHash,
                             Role, IsActive, CreatedAt
                      FROM tbl_Users
                      WHERE Username = @Username";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.VarChar, 50).Value = username;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        UserAccount user;

                        string role = reader["Role"].ToString();

                        if (role == "Admin")
                        {
                            user = new Admin();
                        }
                        else if (role == "Adopter")
                        {
                            user = new Adopter();
                        }
                        else
                        {
                            return null;
                        }

                        user.UserID = Convert.ToInt32(reader["UserID"]);
                        user.Username = reader["Username"].ToString();
                        user.Email = reader["Email"].ToString();
                        user.PasswordHash = reader["PasswordHash"].ToString();
                        user.IsActive = Convert.ToBoolean(reader["IsActive"]);
                        user.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);

                        return user;
                    }
                }
            }
        }


        public int AddUser(UserAccount user)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
            INSERT INTO tbl_Users
            (Username, Email, PasswordHash, Role, IsActive, CreatedAt)
            VALUES
            (@Username, @Email, @PasswordHash, @Role, @IsActive, @CreatedAt);

            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 50)
                        .Value = user.Username;

                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 150)
                        .Value = user.Email;

                    command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 300)
                        .Value = user.PasswordHash;

                    command.Parameters.Add("@Role", SqlDbType.NVarChar, 20)
                        .Value = user.Role.ToString();

                    command.Parameters.Add("@IsActive", SqlDbType.Bit)
                        .Value = user.IsActive;

                    command.Parameters.Add("@CreatedAt", SqlDbType.DateTime2)
                        .Value = user.CreatedAt;

                    int userID = System.Convert.ToInt32(command.ExecuteScalar());

                    user.UserID = userID;

                    return userID;
                }
            }
        }


        public int AddUser(UserAccount user, SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
        INSERT INTO tbl_Users
        (Username, Email, PasswordHash, Role, IsActive, CreatedAt)
        VALUES
        (@Username, @Email, @PasswordHash, @Role, @IsActive, @CreatedAt);

        SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50)
                    .Value = user.Username;

                command.Parameters.Add("@Email", SqlDbType.NVarChar, 150)
                    .Value = user.Email;

                command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 300)
                    .Value = user.PasswordHash;

                command.Parameters.Add("@Role", SqlDbType.NVarChar, 20)
                    .Value = user.Role.ToString();

                command.Parameters.Add("@IsActive", SqlDbType.Bit)
                    .Value = user.IsActive;

                command.Parameters.Add("@CreatedAt", SqlDbType.DateTime2)
                    .Value = user.CreatedAt;

                int userID = Convert.ToInt32(command.ExecuteScalar());

                user.UserID = userID;

                return userID;
            }
        }


    }
}