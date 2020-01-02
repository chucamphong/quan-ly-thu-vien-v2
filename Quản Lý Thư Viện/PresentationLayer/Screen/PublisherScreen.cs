using BusinessLogicLayer;
using DataTransferObject;
using PresentationLayer.Screen.Childs;
using PresentationLayer.Screen.Layouts;

namespace PresentationLayer.Screen
{
    public partial class PublisherScreen : LayoutScreen<Publisher, PublisherService>
    {
        public PublisherScreen()
            : base("Quản lý nhà phát hành")
        {
        }

        protected override void ShowInsertForm()
        {
            var insertForm = new InsertLayoutForm<Publisher, PublisherService>
            {
                Title = "Thêm Nhà Phát Hành",
                Label = "Tên nhà phát hành",
                BtnText = "Thêm nhà phát hành",
            };
            insertForm.ShowDialog();
        }
    }
}
