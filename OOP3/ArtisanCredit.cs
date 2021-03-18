using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Esnaf Kredisi
    class ArtisanCredit:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı...");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
