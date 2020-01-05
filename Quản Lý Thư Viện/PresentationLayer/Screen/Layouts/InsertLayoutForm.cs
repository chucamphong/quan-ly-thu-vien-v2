using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Layouts
{
    public partial class InsertLayoutForm<TEntity, TService> : Form
        where TEntity : class, IEntity, new()
        where TService : IService<TEntity>, new()
    {
        public InsertLayoutForm()
        {
            this.InitializeComponent();
        }

        public string Title
        {
            get => this.lblName.Text;
            set => this.lblTitle.Text = value;
        }

        public string Label
        {
            get => this.lblName.Text;
            set => this.lblName.Text = value;
        }

        public string BtnText
        {
            get => this.btnAdd.Text;
            set => this.btnAdd.Text = value;
        }

        public IService<TEntity> Service { get; } = new TService();

        private void InsertLayoutForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Thông tin không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TEntity entity = new TEntity
            {
                Name = name,
            };

            this.Insert(entity);
        }

        /// <summary>
        /// Gửi truy vấn thêm thông tin đến cơ sở dữ liệu.
        /// </summary>
        /// <param name="entity">Thông tin cần thêm.</param>
        private void Insert(TEntity entity)
        {
            TEntity findEntity = this.Service.SearchByName(entity.Name).FirstOrDefault();

            if (findEntity is null)
            {
                this.Service.Insert(entity);
                this.Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
