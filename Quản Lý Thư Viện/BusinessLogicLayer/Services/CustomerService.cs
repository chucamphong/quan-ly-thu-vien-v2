using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public IEnumerable<Customer> FindByNameOrEmail(string value)
        {
            return (this.Data as ICustomerData).FindByNameOrEmail(value);
        }

        protected override Data<Customer> Entity()
        {
            return new CustomerData();
        }
    }
}
