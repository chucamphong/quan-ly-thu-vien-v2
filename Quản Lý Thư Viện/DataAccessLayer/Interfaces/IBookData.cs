using System.Collections.Generic;
using DataTransferObject;

namespace DataAccessLayer
{
    public interface IBookData : IData<Book>
    {
        IEnumerable<Book> SearchByNameOrAuthorOrPublisherOrCategory(string value);
    }
}