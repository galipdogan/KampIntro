using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
