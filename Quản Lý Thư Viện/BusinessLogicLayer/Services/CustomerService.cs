using System.Collections.Generic;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public IEnumerable<Customer> FindByEmail(string email)
        {
            return (this.Data as ICustomerData).FindByEmail(email);
        }

        public IEnumerable<Customer> FindByPhone(string phone)
        {
            return (this.Data as ICustomerData).FindByPhone(phone);
        }

        public IEnumerable<Customer> SearchByNameOrEmail(string value)
        {
            return (this.Data as ICustomerData).SearchByNameOrEmail(value);
        }

        protected override IData<Customer> Entity()
        {
            return new CustomerData();
        }
    }
}
