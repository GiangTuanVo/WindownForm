using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm.Shop
{
    public class Product
    {
        public int ID { get; set; }
        public string KindOfProduct { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; } = 1;
        public int Price { get; set; }
        public Product()
        {

        }
        public Product(int iD, string kindOfProduct, string productName, int quantity, int price)
        {
            ID = iD;
            KindOfProduct = kindOfProduct;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ID}, {KindOfProduct}, {ProductName}, {Quantity}, {Price}";
        }
    }
}
