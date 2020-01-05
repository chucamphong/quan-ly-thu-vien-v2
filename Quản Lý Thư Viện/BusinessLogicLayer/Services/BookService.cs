using System.Collections.Generic;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class BookService : Service<Book>, IBookService
    {
        public IEnumerable<Book> SearchByNameOrAuthorOrPublisherOrCategory(string value)
        {
            return (this.Data as IBookData).SearchByNameOrAuthorOrPublisherOrCategory(value);
        }

        protected override IData<Book> Entity()
        {
            return new BookData();
        }
    }
}
