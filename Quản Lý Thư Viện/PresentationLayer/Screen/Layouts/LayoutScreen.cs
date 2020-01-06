using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Screen.Layouts
{
    public abstract partial class LayoutScreen<TEntity, TService> : Form
        where TEntity : class, IEntity, new()
        where TService : IService<TEntity>, new()
    {
        private TEntity oldEntityData;

        /// <summary>
        /// Tạo ra thực thể của lớp <see cref="LayoutScreen{TEntity, TService}"/>.
        /// </summary>
        /// <param name="title">Tiêu đề của Form.</param>
        public LayoutScreen(string title)
        {
            this.InitializeComponent();
            this.lblTitle.Text = title;
        }

        protected TService Service { get; } = new TService();

        protected abstract void ShowInsertForm();

        private void LayoutScreen_Load(object sender, EventArgs e)
        {
            this.LoadAll();
        }

        /// <summary>
        /// Thực hiện tìm kiếm theo tên khi người dùng nhấn Enter.
        /// </summary>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string name = (sender as Control).Text;

            if (string.IsNullOrEmpty(name))
            {
                this.LoadAll();
                return;
            }

            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            var entities = this.Service.SearchByName(name).ToList();

            if (entities.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.bindingSource.DataSource = entities;
            }
        }

        /// <summary>
        /// Lưu lại giữ liệu phục vụ cho việc hoàn tác dữ liệu khi người dùng nhập sai.
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldEntityData = this.GetDataAtRow(e.RowIndex);
        }

        /// <summary>
        /// Thực hiện cập nhật dữ liệu khi kết thúc chỉnh sửa.
        /// </summary>
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TEntity entity = this.GetDataAtRow(e.RowIndex);

            if (string.IsNullOrEmpty(entity.Name))
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.RejectEdit(e.RowIndex);
                return;
            }

            // Trường hợp không có gì thay đổi
            if (entity.Name == this.oldEntityData.Name)
            {
                this.RejectEdit(e.RowIndex);
                return;
            }

            try
            {
                this.Service.Update(entity);
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException exception)
            {
                // Trường hợp bị trùng
                if (exception.InnerException.InnerException is SqlException innerException && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    MessageBox.Show($"Dữ liệu bạn nhập đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.RejectEdit(e.RowIndex);
            }
        }

        /// <summary>
        /// Hiện menu tại dòng được chọn trong DataGridView.
        /// </summary>
        private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            this.dataGridView.ClearSelection();

            if (e.RowIndex > -1)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        /// <summary>
        /// Xóa dữ liệu tại hàng được chọn.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàng đang được chọn
            DataGridViewRow rowSelected = this.dataGridView.SelectedRows[0];

            TEntity entity = (TEntity)rowSelected.DataBoundItem;

            try
            {
                this.Service.Delete(entity);

                this.dataGridView.Rows.RemoveAt(rowSelected.Index);

                this.dataGridView.Refresh();

                MessageBox.Show("Xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị Form thêm dữ liệu.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.ShowInsertForm();
            this.LoadAll();
        }

        /// <summary>
        /// Tải tất cả dữ liệu vào DataGridView.
        /// </summary>
        private void LoadAll()
        {
            this.bindingSource.DataSource = this.Service.All().ToList();
        }

        /// <summary>
        /// Lấy dữ liệu tại dòng <paramref name="rowIndex"/>.
        /// </summary>
        /// <param name="rowIndex">Dòng cần lấy thông tin.</param>
        /// <returns>Đối tượng tại dòng <paramref name="rowIndex"/>.</returns>
        private TEntity GetDataAtRow(int rowIndex)
        {
            int id = (int)this.dataGridView.Rows[rowIndex].Cells[0].Value;
            string name = this.dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();

            return new TEntity { Id = id, Name = name };
        }

        /// <summary>
        /// Phục hồi lại dữ liệu.
        /// </summary>
        /// <param name="rowIndex">Dòng cần phục hồi.</param>
        private void RejectEdit(int rowIndex)
        {
            this.dataGridView.Rows[rowIndex].Cells[0].Value = this.oldEntityData.Id;     // Cột ID
            this.dataGridView.Rows[rowIndex].Cells[1].Value = this.oldEntityData.Name;   // Cột Name
        }
    }
}
