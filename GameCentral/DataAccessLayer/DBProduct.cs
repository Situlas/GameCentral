using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBProduct : IDataAccess<Product>
    {
        DBConnection conn = new DBConnection();

        public void Create(Product entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into ProductDB (Name, Price, Description, Stock, Sold ) values (@Name, @Price, @Description, @Stock, @Sold)";
                    cmd.Parameters.AddWithValue("Name", entity.Name);
                    cmd.Parameters.AddWithValue("Price", entity.Price);
                    cmd.Parameters.AddWithValue("Description", entity.Description);
                    cmd.Parameters.AddWithValue("Stock", entity.Stock);
                    cmd.Parameters.AddWithValue("Sold", entity.Sold);
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
                    cmd.CommandText = "DELETE FROM ProductDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public Product Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ProductDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isRead = reader.Read();
                    return new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                }
                //connection.Close();
            }
        }

        public List<Product> GetAll()
        {
            List<Product> ProductList = new List<Product>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ProductDB";
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        Product product = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                        ProductList.Add(product);
                    }

                }
            }
            return ProductList;
        }

        public void Update(Product entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ProductDB SET Name = @Name, Price = @Price, Description = @Description, Stock = @Stock, Sold = @Sold WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Name", entity.Name);
                    cmd.Parameters.AddWithValue("Price", entity.Price);
                    cmd.Parameters.AddWithValue("Description", entity.Description);
                    cmd.Parameters.AddWithValue("Stock", entity.Stock);
                    cmd.Parameters.AddWithValue("Sold", entity.Sold);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
