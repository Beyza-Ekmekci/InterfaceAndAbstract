using InterfaceAndAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Concrete
{
    public class StarbucksCustomerManager : ICustomerService
    {
        public void Save(ICustomerService customer)
        {
            throw new NotImplementedException();
        }
    }
}
