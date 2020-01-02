using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CategoryService : Service<Category>
    {
        protected override Data<Category> Entity()
        {
            return new CategoryData();
        }
    }
}
