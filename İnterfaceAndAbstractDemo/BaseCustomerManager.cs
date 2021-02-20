using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAndAbstractDemo
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db "+customer.FirstName);
        }
    }
}
