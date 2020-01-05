using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccessLayer
{
    public class CustomerData : Data<Customer>, ICustomerData
    {
        public IEnumerable<Customer> FindByEmail(string email)
        {
            return this.Entity.Where(entity => entity.Email == email);
        }

        public IEnumerable<Customer> SearchByNameOrEmail(string value)
        {
            return this.SearchBy(entity => entity.Name.Contains(value) ||
                                           entity.Email.Contains(value));
        }

        public IEnumerable<Customer> FindByPhone(string phone)
        {
            return this.Entity.Where(entity => entity.Phone == phone);
        }
    }
}
