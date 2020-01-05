using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        protected override IData<Author> Entity()
        {
            return new AuthorData();
        }
    }
}
