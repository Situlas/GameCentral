using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class SaleLineItemDB
    {
        public int Id { get; set; }
        public List<SaleLineItem> saleLineItemList { get; set; }
        public double TotaPrice { get; set; }

        public SaleLineItemDB(int id, List<SaleLineItem> sli, double TotalPrice)
        {
            this.Id = id;
            this.saleLineItemList = sli;
            this.TotaPrice = TotalPrice;
        }
    }
}
