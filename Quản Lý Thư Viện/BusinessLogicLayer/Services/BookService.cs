using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class BookService : Service<Book>, IBookService
    {
        protected override Data<Book> Entity()
        {
            return new BookData();
        }
    }
}
