using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicantManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService>  loggerServices)
        {
            //Başvuru bilgileri değerlendirilien alan
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }


        }

        public void KrediOnbilgilendirmesiYap(List<ICreditManager> credits)
        {
            //Birden fazla kredi hesabı yapıp uygun olana BasvuruYap da yapacak

            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
