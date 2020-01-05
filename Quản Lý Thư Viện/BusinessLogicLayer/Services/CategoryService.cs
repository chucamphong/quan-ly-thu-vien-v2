using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        protected override Data<Category> Entity()
        {
            return new CategoryData();
        }
    }
}
