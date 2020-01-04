using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface ICustomerService : IService<Customer>
    {
        IEnumerable<Customer> FindByNameOrEmail(string value);
    }
}
