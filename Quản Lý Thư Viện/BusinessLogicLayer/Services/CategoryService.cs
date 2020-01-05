using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        protected override IData<Category> Entity()
        {
            return new CategoryData();
        }
    }
}
