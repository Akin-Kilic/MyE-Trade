using System;
using System.Collections.Generic;

namespace MyE_Trade
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,"Elma",5,15,"Amasya elması");
            Product product2 = new Product(2,"Armut",6,30,"Taze armut");
            Product product3 = new Product(3,"İncir",10,100,"Aydın inciri");

            Product[] products1 = new Product[] { product1, product2, product3 };
            for (int i = 0; i < products1.Length; i++)
            {
                Console.WriteLine(products1[i].Name);
            }

            Console.WriteLine("---------------------------------");

            List<Product> products2 = new List<Product> { product1,product2,product3};
            foreach (var product in products2)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("---------------------------------");

            int j = 0;
            while (j<products1.Length)
            {
                Console.WriteLine(products1[j].Name);
                j++;
            }
        }
    }
}
