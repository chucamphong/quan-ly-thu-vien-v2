using BusinessLogicLayer;
using DataTransferObject;
using PresentationLayer.Screen.Layouts;

namespace PresentationLayer.Screen
{
    public partial class CategoryScreen : LayoutScreen<Category, CategoryService>
    {
        public CategoryScreen()
            : base("Quản Lý Thể Loại")
        {
        }

        protected override void ShowInsertForm()
        {
            var insertForm = new InsertLayoutForm<Category, CategoryService>
            {
                Title = "Thêm Thể Loại",
                Label = "Tên thể loại",
                BtnText = "Thêm thể loại",
            };
            insertForm.ShowDialog();
        }
    }
}
