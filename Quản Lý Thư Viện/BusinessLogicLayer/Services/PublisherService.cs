using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class PublisherService : Service<Publisher>
    {
        protected override IData<Publisher> Entity()
        {
            return new PublisherData();
        }
    }
}
