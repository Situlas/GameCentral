using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBOrder : IDataAccess<Order>
    {
        DBConnection conn = new DBConnection();

        public void Create(Order entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into OrderDB (CustomerId) values (@CustomerId)";
                    cmd.Parameters.AddWithValue("CustomerId", entity.customer.Id);
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
                    cmd.CommandText = "DELETE FROM OrderDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public Order Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM OrderDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Finding and fetching the result, by also fetching the customer
                    bool isRead = reader.Read();
                    DBCustomer dBCustomer = new DBCustomer();
                    Customer c = dBCustomer.Get(reader.GetInt32(2));
                    return new Order(reader.GetInt32(0), c);
                }
                //connection.Close();
            }
        }

        public List<Order> GetAll()
        {
             List<Order> OrderList = new List<Order>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM OrderDB";
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        DBCustomer dBCustomer = new DBCustomer();
                        Customer c = dBCustomer.Get(reader.GetInt32(2));
                        Order order = new Order(reader.GetInt32(0), c);
                        OrderList.Add(order);
                    }

                }
            }
            return OrderList;
        }

        public void Update(Order entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ProductDB SET CustomerId = @CustomerId WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("CustomerId", entity.customer.Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
