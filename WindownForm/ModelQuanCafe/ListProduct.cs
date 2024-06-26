﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm.ModelQuanCafe
{
    public class ListProduct:Product
    {
        public List<Product> Products = new List<Product>();
        public ListProduct()
        {

        }

        public ListProduct(int no, string type, string name, int price) : base(no, type, name, price)
        {
        }

        public void AddProduct(Product product, int amount)
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
