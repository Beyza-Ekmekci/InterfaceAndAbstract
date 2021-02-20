using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAndAbstractDemo
{
    
    
    public class StarbukcCustomerManager :BaseCustomerManager 
    {
        private IPersonCheckService _personCheckService;
        public StarbukcCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;

        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            { 
                base.Save(customer); 
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

       
    }
}
