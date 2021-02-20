using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public void Save(ICustomerService customer)
        {
            Console.WriteLine("Saved To DB " +customer.F );
        }
    }
}
