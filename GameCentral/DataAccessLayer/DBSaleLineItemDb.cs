using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DBSaleLineItemDb : IDataAccess<SaleLineItemDB>
    {

        DBConnection conn = new DBConnection();

        public void Create(SaleLineItemDB entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into SaleLineItemDB (SaleLineItemId, TotalPrice) values (@SaleLineItemId, @TotalPrice)";
                    cmd.Parameters.AddWithValue("SaleLineItem", entity.Id);
                    double TotalPrice = 0;
                    foreach(var sli in entity.saleLineItemList) {
                        TotalPrice = TotalPrice + (sli.product.Price * Convert.ToDouble(sli.Quantity));
                    }
                    cmd.Parameters.AddWithValue("TotalPrice", TotalPrice);
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
                    cmd.CommandText = "DELETE FROM SaleLineItemDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public SaleLineItemDB Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SaleLineItemDB WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isRead = reader.Read();


                    return new SaleLineItemDB(reader.GetInt32(0), // List of salelineitem), reader.GetInt32(2));
                }
                //connection.Close();
            }
        }

        public List<SaleLineItemDB> GetAll()
        {
            List<SaleLineItemDB> SaleLineItemDbList = new List<SaleLineItemDB>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ProductDB";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SaleLineItemDB saleLineItemDB = new SaleLineItemDB(reader.GetInt32(0), // List of salelineitem), reader.GetInt32(2));
                        SaleLineItemDbList.Add(saleLineItemDB);
                    }
                }
            }
            return SaleLineItemDbList;
        }

        public void Update(SaleLineItemDB entity)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ProductDB SET TotalPrice = @TotalPrice WHERE Id = @Id";
                    double TotalPrice = 0;
                    foreach (var sli in entity.saleLineItemList)
                    {
                        TotalPrice = TotalPrice + (sli.product.Price * Convert.ToDouble(sli.Quantity));
                    }
                    cmd.Parameters.AddWithValue("TotalPrice", TotalPrice);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
