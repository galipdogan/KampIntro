using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate Customer
    //Inheritance - Miras Alma Customer ın özelliklerini miras alıyor
    //
    class CoorporateCustomer :Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
