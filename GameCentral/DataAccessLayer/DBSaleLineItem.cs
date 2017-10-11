using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBSaleLineItem : IDataAccess<SaleLineItem>
    {

        DBConnection conn = new DBConnection();

        public void Create(SaleLineItem entity)
        {
                using (SqlConnection connection = conn.OpenConnection())
                {

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Insert into SaleLineItem (ProductId, Quantity, OrderDB_OrderId) values (@ProductId, @Quantity, @OrderDB_OrderId)";
                        cmd.Parameters.AddWithValue("ProductId", entity.SliProduct.Id);
                        cmd.Parameters.AddWithValue("Quantity", entity.Quantity);
                        cmd.Parameters.AddWithValue("OrderDB_OrderId", entity.OrderDB_OrderId);
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
                    cmd.CommandText = "DELETE FROM SaleLineItem WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public SaleLineItem Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection()) 
            {
                using(SqlCommand cmd = connection.CreateCommand()) 
                {
                    cmd.CommandText = "SELECT * FROM SaleLineItem WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", id);
               
                    //Finding and fetching result from SQL database using DBproduct to also find the corresponding product for the SaleLineItem
                    DBProduct dbProduct = new DBProduct();
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isRead = reader.Read();
                    return new SaleLineItem(reader.GetInt32(0), 
                        dbProduct.Get(reader.GetInt32(1)),
                        reader.GetInt32(2), reader.GetInt32(3));
                }
            }   
        }

        public List<SaleLineItem> GetAll()
        {
            List<SaleLineItem> SaleLineItemList = new List<SaleLineItem>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SaleLineItem";
                    SqlDataReader reader = cmd.ExecuteReader();
                    DBProduct dbProduct = new DBProduct();

                    while (reader.Read())
                    {
                        SaleLineItem sli = new SaleLineItem(reader.GetInt32(0), dbProduct.Get(reader.GetInt32(1)), reader.GetInt32(2), reader.GetInt32(3));
                        SaleLineItemList.Add(sli);
                    }

                }
            }
            return SaleLineItemList;
        }

        public void Update(SaleLineItem entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE SaleLineItem SET Quantity = @Quantity, WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
