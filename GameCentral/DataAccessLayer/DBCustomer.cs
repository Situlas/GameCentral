using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBCustomer : IDataAccess<Customer>
    {
        DBConnection conn = new DBConnection();

        public void Create(Customer entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into CustomerDB (Phone, FName, LName, City, ZipCode, Email, CVR, CustomerType) values (@Phone, @FName, @LName, @City, @ZipCode, @Email, @CVR, @CustomerType)";
                    cmd.Parameters.AddWithValue("Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("FName", entity.FName);
                    cmd.Parameters.AddWithValue("LName", entity.LName);
                    cmd.Parameters.AddWithValue("City", entity.City);
                    cmd.Parameters.AddWithValue("ZipCode", entity.ZipCode);
                    cmd.Parameters.AddWithValue("Email", entity.Email);
                    cmd.Parameters.AddWithValue("CVR", entity.CVR);
                    cmd.Parameters.AddWithValue("CustomerType", entity.CustomerType);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }

        }
        public void Delete(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM CustomerDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public Customer Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CustomerDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isRead = reader.Read();
                    return new Customer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetInt32(7), reader.GetBoolean(8));
                }
                //connection.Close();
            }
        }

        public List<Customer> GetAll()
        {
            List<Customer> CustomerList = new List<Customer>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CustomerDB";
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        Customer customer = new Customer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetInt32(7), reader.GetBoolean(8));
                        CustomerList.Add(customer);
                    }

                }
            }
            return CustomerList;
        }

        public void Update(Customer entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CustomerDB SET Phone = @Phone, FName = @FName, LName = @LName, City = @City, ZipCode = @ZipCode, Email = @Email, CVR = @CVR, CustomerType = @CustomerType WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("FName", entity.FName);
                    cmd.Parameters.AddWithValue("LName", entity.LName);
                    cmd.Parameters.AddWithValue("City", entity.City);
                    cmd.Parameters.AddWithValue("ZipCode", entity.ZipCode);
                    cmd.Parameters.AddWithValue("Email", entity.Email);
                    cmd.Parameters.AddWithValue("CVR", entity.CVR);
                    cmd.Parameters.AddWithValue("CustomerType", entity.CustomerType);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }

        }
    }
}

