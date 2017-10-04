using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DBSaleLineItem : IDataAccess<SaleLineItem>
    {

        DBConnection conn = new DBConnection();

        public void Create(SaleLineItem entity)
        {
                using (SqlConnection connection = conn.OpenConnection())
                {

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Insert into SaleLineItem (ProductId, Quantity) values (@ProductId, @Quantity)";
                        cmd.Parameters.AddWithValue("ProductId", entity.product.Id);
                        cmd.Parameters.AddWithValue("Quantity", entity.Quantity);
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
            
        }

        public List<SaleLineItem> GetAll()
        {
            
        }

        public void Update(SaleLineItem entity)
        {
            
        }
    }
}
