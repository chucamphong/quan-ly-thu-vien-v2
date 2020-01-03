using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer.Services
{
    public class CustomerService : Service<Customer>
    {
        protected override Data<Customer> Entity()
        {
            return new CustomerData();
        }
    }
}
