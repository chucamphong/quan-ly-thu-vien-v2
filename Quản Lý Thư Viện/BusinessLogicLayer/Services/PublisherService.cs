using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class PublisherService : Service<Publisher>
    {
        protected override Data<Publisher> Entity()
        {
            return new PublisherData();
        }
    }
}
