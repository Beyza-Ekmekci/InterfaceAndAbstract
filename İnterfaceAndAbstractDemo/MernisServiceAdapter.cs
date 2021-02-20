using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaceAndAbstractDemo
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,customer.FirstName
                .ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
