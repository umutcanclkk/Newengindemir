using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CustomerManager : ICustomerService
    {
        ICustomerValitadionService _valitadionService;

        public CustomerManager(ICustomerValitadionService valitadionService)
        {
            _valitadionService = valitadionService;
        }

        public void Add(Customer customer)
        {
            if (_valitadionService.Validate(customer)==true)
            {
                Console.WriteLine("Müsteri Eklendi");
            }
            else
            {
                Console.WriteLine("Müşteri Bulunamadı");
            }
        }

       
       public void Delete(Customer customer)
        {
            Console.WriteLine("Müsteri Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncelelndi");
        }
    }
}
