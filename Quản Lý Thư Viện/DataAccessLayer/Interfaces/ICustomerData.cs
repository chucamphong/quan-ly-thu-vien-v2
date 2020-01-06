using System.Collections.Generic;
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
