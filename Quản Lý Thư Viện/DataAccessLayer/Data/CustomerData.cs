using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class CustomerData : Data<Customer>, ICustomerData
    {
        public IEnumerable<Customer> FindByNameOrEmail(string value)
        {
            return this.Entity.Where(entity => entity.Name.Contains(value) ||
                                               entity.Email.Contains(value));
        }
    }
}
