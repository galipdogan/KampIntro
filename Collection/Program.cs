using System;
using System.Collections.Generic;


namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylar oluşturulan sınırlar içinde kalırlar. Ekleme yapamazsınız.
            //string[] isimler = new string[] {"Galip", "Engin", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//Yeni bir tane 5 elamanlı dizi oluşturdun. Ancak bir üstteki veriler
            ////gelmez. Çünkü yeni sıfırdan referans verdiğin adresi değiştirdin ve boş olan yeni bir dizi oluştu.
            //isimler[40] = "ilker";
            //Console.WriteLine(isimler[4]);//4 eleman ilker olarak gelir 
            //Console.WriteLine(isimler[0]);//1. Buradaki eleman boş gelir

            //Collection - List yaparak  koleksiyonlarda arrayları kaybetmeyecek şekilde bir altyapı vardır.
            List<string> isimler2 = new List<string>() {"Galip", "Engin", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker ");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
