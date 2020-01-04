using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface ICustomerService : IService<Customer>
    {
        IEnumerable<Customer> SearchByNameOrEmail(string value);

        IEnumerable<Customer> FindByEmail(string email);

        IEnumerable<Customer> FindByPhone(string phone);
    }
}
