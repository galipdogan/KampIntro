using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCredit:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Bireysel Kredi Ödeme Planı Hesaplandı.");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
            
        }
    }
}
