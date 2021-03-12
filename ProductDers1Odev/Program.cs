using System;

namespace ProductDers1Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "T-shirt";
            product1.ProductPrice = 200;
            product1.Stock = 10;

            Product product2 = new Product();
            product2.ProductName = "Kazak";
            product2.ProductPrice = 100;
            product2.Stock = 8;

            Product product3 = new Product();
            product3.ProductName = "Pantolon";
            product3.ProductPrice = 250;
            product3.Stock = 5;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + "  " + product.ProductPrice + " " + product.Stock);
            }
            Console.WriteLine("foreach sonu");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " " + products[i].ProductPrice + " " + products[i].Stock);
            }
            Console.WriteLine("for sonu");
            var uzunluk = 0;
            while (uzunluk < products.Length)
            {
                Console.WriteLine(products[uzunluk].ProductName + " " + products[uzunluk].ProductPrice + " " + products[uzunluk].Stock);
                uzunluk++;
            }
            Console.WriteLine("while sonu");

        }
        public class Product
        {
            public string ProductName { get; set; }
            public double ProductPrice { get; set; }
            public int Stock { get; set; }
        }
    }
}