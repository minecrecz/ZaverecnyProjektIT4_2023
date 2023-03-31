using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using projekt_topAPP.třídy;

namespace projekt_topAPP
{
    public class SqlRepository
    {

        private static readonly string connectionString = "Data Source=vps.jhlavacek.cz;Initial Catalog=Dvorak;User ID=DvorakAdam;Password=Dv0r@k@d@m;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public static List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))

            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employee";

                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            employees.Add(new Employee(reader.GetInt32(0), reader["FirstName"].ToString(), reader["Forename"].ToString(), reader["BirthDay"].ToString(), reader["Email"].ToString(), reader["Phone"].ToString()));

                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }
        public static void DeleteEmployee(string personalID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"delete from Employee where PersonalID={personalID}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"insert into Employee (FirstName,Forename,BirthDay,Email,Phone) VALUES (@FirstNameValue,@ForenameValue,@BirthDayValue,@EmailValue,@PhoneValue)";
                    
                    command.Parameters.AddWithValue("@FirstNameValue", employee.FirstName);
                    command.Parameters.AddWithValue("@ForenameValue", employee.ForeName);
                    command.Parameters.AddWithValue("@BirthDayValue", employee.BirthDate);
                    command.Parameters.AddWithValue("@EmailValue", employee.Email);
                    command.Parameters.AddWithValue("@PhoneValue", employee.Phone);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        public static void RegisterUser(string username, string password, string rights)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            HMACSHA512 hmac = new();
            command.CommandText = "INSERT INTO [User] (Username,PasswordHash,PasswordSalt,Rights) VALUES (@name,@hash,@salt,@rights)";
            command.Parameters.AddWithValue("name", username);
            command.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            command.Parameters.AddWithValue("salt", hmac.Key);
            command.Parameters.AddWithValue("rights", rights);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static User? CheckLogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM [User] WHERE Username=@name";
            command.Parameters.AddWithValue("name", username);
            SqlDataReader reader = command.ExecuteReader();
            User? user = null;
            if (reader.Read())
            {
                HMACSHA512 hmac = new((byte[])reader[3]);
                if (hmac.ComputeHash(Encoding.UTF8.GetBytes(password)).SequenceEqual((byte[])reader[2]))
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(4));
                }
            }
            reader.Close();
            conn.Close();
            return user;
        }

        public static void ChangePassword(int id, string newpassword)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            HMACSHA512 hmac = new();
            command.CommandText = "Update [User] SET PasswordHash=@hash,PasswordSalt=@salt WHERE ID=@id";
            command.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(newpassword)));
            command.Parameters.AddWithValue("salt", hmac.Key);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
