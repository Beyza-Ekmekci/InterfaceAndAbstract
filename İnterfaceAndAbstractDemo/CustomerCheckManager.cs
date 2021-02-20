using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAndAbstractDemo
{
    class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
