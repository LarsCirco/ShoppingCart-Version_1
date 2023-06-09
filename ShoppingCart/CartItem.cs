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
        private Product product;
        private int Antall;

        public CartItem(Product product, int antall)
        {
            this.product = product;
            Antall = antall;
        }

        public void Add(int antall)
        {
          Antall += antall;
        }

        public Product ShowProduct()
        {
            return product;
        }

        public int GetCount()
        {
            return Antall;
        }

        public int GetTotalPrice()
        {
            return product.HentePris() * Antall;
        }
    }
}