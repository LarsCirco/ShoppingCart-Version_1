using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        public string ProductName { get; }
        public int ProductPrice { get; }

        public Product(string name, int price)
        {
            ProductName = name;
            ProductPrice = price;
        }

    }
}
