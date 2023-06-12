using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class CartItem
    {
        public Product product { get; }
        public int Ammount { get; set; }

        public CartItem(Product product, int amount)
        {
            this.product = product;
            Ammount = amount;
        }

        public void Add(int amount)
        {
          Ammount += amount;
        }


        public int GetTotalPrice()
        {
            return product.ProductPrice * Ammount;
        }

        public string PrintOutAllInfo()
        {
            return $"Antall! {Ammount} Prodrukt Navn: {product.ProductName} produkt pris {product.ProductPrice}";
        }
    }
}