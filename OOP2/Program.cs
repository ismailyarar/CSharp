using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //müşteri kişi olduğunda CompanyName sıkıntı olur.
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirtsName = "ismail";
            customer1.LastName = "demirci";
            customer1.TcNo = "123456789";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Youtube";
            customer2.TaxNumber = "124563";
            customer2.CustomerNumber = "123456";



            //Gerçek-Tüzel 
            //SOLID 

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();
            //Customer ikisininde referansını tutabiliyor çünkü ebeveyn

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            //oluşturulan tüm müşterileri yollayabiliyoruz

        }
    }
}
