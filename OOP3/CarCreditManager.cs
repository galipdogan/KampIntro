using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
