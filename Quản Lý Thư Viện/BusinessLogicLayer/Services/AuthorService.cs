using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        protected override Data<Author> Entity()
        {
            return new AuthorData();
        }
    }
}
