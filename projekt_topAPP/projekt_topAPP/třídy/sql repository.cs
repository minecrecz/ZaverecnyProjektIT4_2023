using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt_topAPP.třídy;

namespace projekt_topAPP
{
    internal class sql_repository
    {

        private string connectionString = @"Data Source=vps.jhlavacek.cz;Initial Catalog=Dvorak;User ID=DvorakAdam;Password=********;Connect Timeout=30;Encrypt=False;";
        /*
        private List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from User";
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user =new User(reader["Name"].ToString()
                                , (byte[])reader["PasswordHash"]
                                , (byte[])reader["passwordSalt"], 
                                reader["Rights"].ToString())
                                ;
                            users.Add(user);
                        }
                        
                        
                        
                    }
                }
                conn.Close();
            }
            return users;
        
      public List<User> GetUsers(string searchString)
       {
           List<User> users = new List<User>();
           using (SqlConnection sqlConnection = new SqlConnection(connectionString))
           {
               sqlConnection.Open();
               using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Name like @Search";
                    cmd.Parameters.AddWithValue("Search", "%" + searchString + "%");
                   using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                      {
                           var user = new User(reader["Name"].ToString()
                                             , (byte[])reader["PasswordHash"]
                                             , (byte[])reader["PasswordSalt"])
                               
                              ;
                            
                           users.Add(user);
                        }
                    }
                }
                sqlConnection.Close();
           }
            return users;
        }
        public User? GetUser(string username)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
           {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Name=@Name";
                    cmd.Parameters.AddWithValue("Name", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                       {
                            user = new User(reader["Name"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"])
                                
                                ;
                            
                                               }
                    }
                }
                sqlConnection.Close();
            }
           return user;
        }
        public void ConvertUsersToHashed()
        {
            var users = GetUsers();
            foreach (var user in users)
            {
                
            }
        }
        */
        public List<Employee> GetEmployees()
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

                            employees.Add(new Employee(Convert.ToInt32(reader["PersonalID"]), reader["FirstName"].ToString(), reader["Forename"].ToString(), reader["Email"].ToString(), reader["Phone"].ToString(), reader["BirthDay"].ToString()));

                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }
        public void DeleteEmployee(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"delete from Employee where PersonalID={id}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


    }
}
