using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IBookService : IService<Book>
    {
        IEnumerable<Book> SearchByNameOrAuthorOrPublisherOrCategory(string value);
    }
}
