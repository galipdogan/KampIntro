using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri Alanı
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "123456";
            customer1.FirstName = "Galip";
            customer1.LastName = "Doğan";
            customer1.TcNo = "000000000";

            //Tüzel Müsteri Alanı
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "654321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456790";


            //Gerçek Müsteri-Tüzel Müsteri bunlar müşteri olmasına rağmen farklı tipte olduklarından mutlaka ayrı sınıflandırılmalıdırlar.

            /*SOLID kavramının L =>
            Liskov Substitution : Kodumuzda herhangi bir değişiklik yapmaya gerek kalmadan
            türetilmiş sınıfları (sub class) türedikleri
            ata sınıfın (base class) yerine kullanabilmeliyiz.*/

            Customer customer3 = new IndividualCustomer(); //customer class ile bağlantılı olan gerçek müsteri de oluşturabiliyoruz.Inheritance sayesinde
            Customer customer4 = new CoorporateCustomer();//customer class ile bağlantılı olan tüzel müsteri de oluşturabiliyoruz.Inheritance sayesinde

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);





        }
    }
}
