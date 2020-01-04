using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public interface ICustomerData : IData<Customer>
    {
        IEnumerable<Customer> FindByEmail(string email);

        IEnumerable<Customer> FindByPhone(string phone);

        IEnumerable<Customer> SearchByNameOrEmail(string value);
    }
}
