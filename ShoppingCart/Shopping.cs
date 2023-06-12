using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Shopping
    {
        private List<CartItem> Items { get; } = new List<CartItem>();

        public void Buy(Product product, int quantity)
        {
            var DoesItExist = Items.FirstOrDefault(item => item.product.ProductName == product.ProductName);

            if (DoesItExist == null)
            {
                Items.Add(new CartItem(product, quantity));
            }
            else
            {
                DoesItExist.Add(quantity);
            }

            Console.WriteLine($"Du kjøpte {quantity} stk. {product.ProductName}");
        }
        public void ShowCart()
        {
            if (Items.Count==0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;

            foreach (var item in Items)
            {

                totalPrice += item.GetTotalPrice();
                Console.WriteLine(" " + item.PrintOutAllInfo());
            }
            Console.WriteLine($"Totalpris: {totalPrice}");
        }


    }
}
