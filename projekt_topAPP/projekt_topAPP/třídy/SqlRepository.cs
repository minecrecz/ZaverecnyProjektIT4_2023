using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
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
        public static void UpdateEmployee(int PersonalID,Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"UPDATE Employee set FirstName=@FirstNameValue, Forename=@ForenameValue,BirthDay=@BirthDayValue,Email=@EmailValue,Phone=@PhoneValue WHERE PersonalID=@personalID";
                    command.Parameters.AddWithValue("personalID", employee.PersonalID);
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
        public static List<projekt_topAPP.třídy.Contract> GetContracts()
        {

            List<projekt_topAPP.třídy.Contract> contracts = new List<projekt_topAPP.třídy.Contract>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))

            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contract";

                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            contracts.Add(new projekt_topAPP.třídy.Contract(reader.GetInt32(0), reader["Customer"].ToString(), reader["Description"].ToString()));

                        }
                    }
                }
                sqlConnection.Close();
            }
            return contracts;
        }
        public static void DeleteContract(string ContractlNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"delete from Contract where ContractNumber={ContractlNumber}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void AddContract(projekt_topAPP.třídy.Contract contract)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"insert into Contract (Customer,Description) VALUES (@CustomerValue,@DescriptionValue)";

                    command.Parameters.AddWithValue("@CustomerValue", contract.Customer);
                    command.Parameters.AddWithValue("@DescriptionValue", contract.Description);
                     
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static List<User> GetUsers()
        {

            List<User> users  = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))

            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID,Username,Rights FROM [User]";

                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            users.Add(new User(reader.GetInt32(0), reader["Username"].ToString(), reader["Rights"].ToString() ));

                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }
        public static void DeleteUser(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"delete from [User] where ID={ID}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static List<Work> GetWorks()
        {
            List<Work> works = new List<Work>();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select IDWork,NameWork,DescriptionWork from Work";
                    connection.Open();
                    using (SqlDataReader reader= command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            works.Add(new Work (reader.GetInt32(0), reader["NameWork"].ToString(), reader["DescriptionWork"].ToString()));
                        }
                    }
                }
                connection.Close ();
            }
            return works;
        }
        public static void DeleteWork(string IDWork)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = $"delete from [Work] where IDWork={IDWork}";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        
        

    }
}
