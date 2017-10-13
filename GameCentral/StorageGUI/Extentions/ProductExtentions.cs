
using StorageGUI.IGameCentralServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StorageGUI.Extentions
{
   public static class ProductExtentions
    {
        public static void Create(this Product obj, int id, string name, double price, string description, int stock, int sold)
        {

            obj.Id = 0;
            obj.Name = name;
            obj.Price = price;
            obj.Description = description;
            obj.Stock = stock;
            obj.Sold = 0;
            
        }
    }
}
