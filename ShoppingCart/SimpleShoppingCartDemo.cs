using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ShoppingCart
    {
        internal class SimpleShoppingCartDemo
        {
            public static void Run()
            {
                var products = new List<Product>
                {
                    new Product("A", 40),
                    new Product("B", 70),
                    new Product("C", 30)
                };


                var HandleKurv = new Shopping();

                HandleKurv.Buy(products[0], 1);
                HandleKurv.Buy(products[1], 3);
                HandleKurv.Buy(products[2], 2);
                HandleKurv.ShowCart();
            }
            
        }
    }
    