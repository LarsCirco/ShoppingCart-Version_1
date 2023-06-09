using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }

        public Product(string name, int price)
        {
            ProductName = name;
            ProductPrice = price;
        }

        public string HenteNavn()
        {
            return ProductName;
        }
        public int HentePris()
        {
            return ProductPrice;
        }

    }
}
