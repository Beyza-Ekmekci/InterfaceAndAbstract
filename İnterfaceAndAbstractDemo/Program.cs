using System;

namespace İnterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbukcCustomerManager(new MernisServiceAdapter());
           
            Customer customer1 = new Customer();
            customer1.FirstName = "Beyza";
            customer1.LastName = "Ekmekçi";
            customer1.Id = 1;
            customer1.NationalityId = "12345678910";
            customer1.DateOfBirth = new DateTime(1995, 4, 9);
            
            baseCustomerManager.Save(customer1);
            Console.ReadLine();

        }
    }
}
