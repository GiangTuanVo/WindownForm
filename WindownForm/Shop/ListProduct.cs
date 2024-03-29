using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm.Shop
{
    public class ListProduct : Product
    {
        public ListProduct()
        {

        }
        public List<Product> Products = new List<Product>();
        public ListProduct(int iD, string kindOfProduct, string productName, int quantity, int price) 
            : base(iD, kindOfProduct, productName, quantity, price)
        {
        }
        public void AddProduct(Product product,int amount)
        {
            product.Quantity = amount;
            product.Price *= amount;
            Products.Add(product);
        }
        public int TotalPrice()
        {
            int totalPrice = 0;
            foreach (var item in Products)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
}
