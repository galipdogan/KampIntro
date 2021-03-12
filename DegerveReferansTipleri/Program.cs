using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 - değer tipindeki veri tipidir. O anki değeri tutar

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//burada sayilar1 artık sayılar2 nin adresini tutar pointer gibi.
            sayilar2[0] = 999; // sayilar2 nin 0. elemanı yani 100 değişir yerine artık 999 gelmiştir.
            //sayilar1[0] 999 - Referans tipindeki veri tipidir. Bellekteki adresi tutar pointer gibi ve 



        }
    }
}
