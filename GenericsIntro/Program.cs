using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listelerde <> mutlaka verilen tipe göre veri girilmelidir.
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Galip");

            Console.WriteLine(isimler);
        }
    }
}
