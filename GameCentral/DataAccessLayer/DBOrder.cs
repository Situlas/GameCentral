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


                    cmd.CommandText = "Insert into OrderDB (CustomerId, SaleLineItemDBId) values (@CustomerId, @SaleLineItemDBId)";
                    cmd.Parameters.AddWithValue("CustomerId", entity.customer.Id);
                    cmd.Parameters.AddWithValue("SaleLineItemDBId", entity.saleLineItem.Id);
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

                    
                    bool isRead = reader.Read();

                  
                    DBCustomer dBCustomer = new DBCustomer();
                    Customer c = dBCustomer.Get(reader.GetInt32(2));
                    // DBSaleLineitem dBSaleLineItem = new DBSaleLineItem();
                    // SaleLineItemDB sliDb = dBSaleLineItem.Get(reader.GetInt32(2));
                    return new Order(reader.GetInt32(0), c, sliDb);
                }
                //connection.Close();
            }
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
