using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm.ModelQuanCafe
{
    public class Product
    {
        public int No { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } = 1;
        public int Price { get; set; }

        public Product()
        {

        }

        public Product(int no, string type, string name, int quantity, int price)
        {
            No = no;
            Type = type;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{No}, {Type}, {Name}, {Quantity}, {Price}";
        }
    }
}
