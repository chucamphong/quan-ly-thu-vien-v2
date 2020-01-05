using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;
using DataTransferObject;
using PresentationLayer.Screen.Childs;

namespace PresentationLayer.Screen
{
    internal enum Column
    {
        Id,
        Name,
        Email,
        Birthday,
        Address,
        Phone,
    }

    public partial class CustomerScreen : Form
    {
        private readonly ICustomerService customerService = new CustomerService();
        private readonly string txtSearchPlaceholderText = "Nhập tên hoặc địa chỉ email để tìm kiếm...";
        private Customer oldCustomerData;

        public CustomerScreen()
        {
            this.InitializeComponent();
        }

        private void CustomerScreen_Load(object sender, System.EventArgs e)
        {
            this.LoadAll();
        }

        /// <summary>
        /// Lấy tất cả khách hàng đưa vào DataGridView.
        /// </summary>
        private async void LoadAll()
        {
            this.customerBindingSource.DataSource = (await this.customerService.All()).ToList();
        }

        /// <summary>
        /// Kết hợp với hàm <see cref="TxtSearch_Enter"/> để tạo hiệu ứng Placeholder.
        /// </summary>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string value = this.txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                this.LoadAll();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                ICollection<Customer> customers = this.FindByNameOrEmail(value);
                this.customerBindingSource.DataSource = customers;
            }
        }

        /// <summary>
        /// Kết hợp với hàm <see cref="TxtSearch_KeyDown"/> để tạo hiệu ứng Placeholder.
        /// </summary>
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            string value = this.txtSearch.Text.Trim();

            if (value == this.txtSearchPlaceholderText)
            {
                this.txtSearch.Text = string.Empty;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            string value = this.txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                this.txtSearch.Text = this.txtSearchPlaceholderText;
            }
        }

        /// <summary>
        /// Tìm kiếm <paramref name="value"/> theo địa chỉ email hoặc tên.
        /// </summary>
        /// <param name="value">Giá trị cần tìm kiếm.</param>
        /// <returns>Các bản ghi có giá trị phù hợp.</returns>
        private ICollection<Customer> FindByNameOrEmail(string value)
        {
            ICollection<Customer> customers = this.customerService.SearchByNameOrEmail(value).ToList();

            return customers;
        }

        /// <summary>
        /// Lưu lại dữ liệu để phục hồi lại khi dữ liệu mới không hợp lệ.
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldCustomerData = this.GetCustomerAtSelectedRow();
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = this.GetCustomerAtSelectedRow();

            // Trường hợp không có gì thay đổi
            if (customer == this.oldCustomerData)
            {
                return;
            }

            try
            {
                this.customerService.Update(customer);

                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
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

                // Phục hồi lại dữ liệu cũ
                this.RejectEdit();
            }

            this.dataGridView.ClearSelection();
        }

        /// <summary>
        /// Lấy thông tin khách hàng tại hàng đang được chọn trong DataGridView.
        /// </summary>
        /// <returns>Thông tin khách hàng.</returns>
        private Customer GetCustomerAtSelectedRow()
        {
            return (Customer)((Customer)this.dataGridView.SelectedRows[0].DataBoundItem).Clone();
        }

        /// <summary>
        /// Gán lại dữ liệu cũ vào cột đang được chọn.
        /// </summary>
        private void RejectEdit()
        {
            this.dataGridView.SelectedRows[0].Cells[0].Value = this.oldCustomerData.Id;
            this.dataGridView.SelectedRows[0].Cells[1].Value = this.oldCustomerData.Name;
            this.dataGridView.SelectedRows[0].Cells[2].Value = this.oldCustomerData.Email;
            this.dataGridView.SelectedRows[0].Cells[3].Value = this.oldCustomerData.Birthday;
            this.dataGridView.SelectedRows[0].Cells[4].Value = this.oldCustomerData.Address;
            this.dataGridView.SelectedRows[0].Cells[5].Value = this.oldCustomerData.Phone;
        }

        /// <summary>
        /// Thực hiện kiểm tra tính đúng đắn của dữ liệu khi người dùng nhập.
        /// </summary>
        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue.ToString();

            switch (e.ColumnIndex)
            {
                case (int)Column.Name:
                    e.Cancel = !this.ValidateName(value);
                    break;
                case (int)Column.Email:
                    e.Cancel = !this.ValidateEmail(value);
                    break;
                case (int)Column.Birthday:
                    e.Cancel = !this.ValidateBirthday(value);
                    break;
                case (int)Column.Address:
                    e.Cancel = !this.ValidateAddress(value);
                    break;
                case (int)Column.Phone:
                    e.Cancel = !this.ValidatePhoneNumber(value);
                    break;
            }
        }

        /// <summary>
        /// Kiểm tra <paramref name="name"/> có phải là tên hợp lệ.
        /// </summary>
        /// <param name="name">Họ và tên.</param>
        /// <returns><see langword="true"/> nếu hợp lệ, <see langword="false"/> nếu không hợp lệ.</returns>
        private bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra <paramref name="email"/> có phải là một địa chỉ email hợp lệ.
        /// </summary>
        /// <param name="email">Địa chỉ email.</param>
        /// <returns><see langword="true"/> nếu hợp lệ, <see langword="false"/> nếu không hợp lệ.</returns>
        private bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Địa chỉ email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validation.IsEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra <paramref name="birthday"/> có phải là một ngày sinh hợp lệ.
        /// </summary>
        /// <param name="birthday">Ngày sinh.</param>
        /// <returns><see langword="true"/> nếu hợp lệ, <see langword="false"/> nếu không hợp lệ.</returns>
        private bool ValidateBirthday(string birthday)
        {
            if (string.IsNullOrEmpty(birthday))
            {
                MessageBox.Show("Ngày tháng năm sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(birthday, out var _))
            {
                MessageBox.Show("Ngày tháng năm sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra <paramref name="address"/> có phải là địa chỉ hợp lệ.
        /// </summary>
        /// <param name="address">Ngày sinh.</param>
        /// <returns><see langword="true"/> nếu hợp lệ, <see langword="false"/> nếu không hợp lệ.</returns>
        private bool ValidateAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của điện thoại khách hàng.
        /// </summary>
        /// <param name="phone">Số điện thoại khách hàng.</param>
        /// <returns><see langword="true"/> nếu số điện thoại hợp lệ và ngược lại trả về <see langword="false"/>.</returns>
        private bool ValidatePhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validation.IsPhoneNumber(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new InsertCustomerForm().ShowDialog();
            this.LoadAll();
        }

        private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            this.dataGridView.ClearSelection();

            if (e.RowIndex > -1)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)this.dataGridView.SelectedRows[0].DataBoundItem;

            this.customerService.Delete(customer);

            this.LoadAll();
        }

        private void BorrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)this.dataGridView.SelectedRows[0].DataBoundItem;

            new BorrowBooksForm(customer).ShowDialog();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)this.dataGridView.SelectedRows[0].DataBoundItem;

            new HistoryForm(customer).ShowDialog();
        }
    }
}
