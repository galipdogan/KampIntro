using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        //encapsulation 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi!");
        }
        //void metodları git yap bitir olarak kullanılır.
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi!");
        }

        

        // int,bool,double... değer tip
        //diziler,class,abstract class, interface... referans tip
        //ref out örneklere tekrar bakılabilir.
        
    }
}
