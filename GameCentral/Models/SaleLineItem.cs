using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class SaleLineItem
    {
        public int Id { get; set; }
        public Product SliProduct { get; set; }
        public int Quantity { get; set; }
        public int OrderDB_OrderId { get; set; }

        public SaleLineItem(int Id, Product Product, int Quantity, int OrderDB_OrderId)
        {
            this.Id = Id;
            this.SliProduct = Product;
            this.Quantity = Quantity;
            this.OrderDB_OrderId = OrderDB_OrderId;

        }
    }
}
