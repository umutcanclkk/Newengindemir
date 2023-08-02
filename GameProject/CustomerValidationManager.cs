using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CustomerValidationManager : ICustomerValitadionService
    {


        public bool Validate(Customer customer)
        {
            if (customer.Id == 2 && customer.NationalityId == "123456" && customer.FirstName == "Eylül" && customer.LastName== "Biter" && customer.DateOfBirth == new DateTime(2002, 12, 21))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
