using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//(mobilya diyelim)
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            // İkinci kullanım örneği üstteki ile aynı yazılımı farklı
            Product product2 = new Product{Id = 2, CategoryId = 5,
                ProductName = "Sandalye", UnitPrice = 300, UnitInStock = 35};


            /* Instance creation -örnek oluşturma*/
            // PascalCase -camelCase bir sınıfın örneğini instance oluşturuken kullanılan biçim
            // Case sevsitive -csharp küçük büyük duyarlıdır
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            // Referans tiptelerde herşey bellekteki adresi ile yapılır. O bellek adresindeki değeri değiştirdin.
            Console.WriteLine(product1.ProductName);

         

        }
    }
}
