using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            CarCreditManager carCreditManager = new CarCreditManager();
            MortgageManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {new SmsLoggerService(), new FileLoggerService()};


            ApplicantManager applicantManager = new ApplicantManager();
            applicantManager.BasvuruYap(new ArtisanCredit(), loggers);


            List<ICreditManager> creditList = new List<ICreditManager>() {personalFinanceCredit, carCreditManager };

            //applicantManager.KrediOnbilgilendirmesiYap(creditList);

        }
    }
}
