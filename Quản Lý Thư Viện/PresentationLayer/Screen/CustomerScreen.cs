using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Screen
{
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

        private async void LoadAll()
        {
            this.customerBindingSource.DataSource = (await this.customerService.All()).ToList();
        }

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
            ICollection<Customer> customers = this.customerService.FindByNameOrEmail(value).ToList();

            return customers;
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldCustomerData = this.GetCustomerAtSelectedRow();
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = this.GetCustomerAtSelectedRow();

            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Email))
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.RejectEdit();
                return;
            }

            try
            {
                this.customerService.Update(customer);
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

                this.RejectEdit();
            }
        }

        private Customer GetCustomerAtSelectedRow()
        {
            return (Customer)((Customer)this.dataGridView.SelectedRows[0].DataBoundItem).Clone();
        }

        private void RejectEdit()
        {
            this.dataGridView.SelectedRows[0].Cells[0].Value = this.oldCustomerData.Id;
            this.dataGridView.SelectedRows[0].Cells[1].Value = this.oldCustomerData.Name;
            this.dataGridView.SelectedRows[0].Cells[2].Value = this.oldCustomerData.Email;
            this.dataGridView.SelectedRows[0].Cells[3].Value = this.oldCustomerData.Birthday;
            Console.WriteLine("Hello " + this.dataGridView.SelectedRows[0].Cells[3].ValueType);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView.Columns[e.ColumnIndex].Name == "Birthday")
            //{
            //    this.rectangle = this.dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //    this.dataGridView.Size = new Size(this.rectangle.Width, this.rectangle.Height);
            //    this.dataGridView.Location = new Point(this.rectangle.X, this.rectangle.Y);
            //    this.dateTimePicker.Visible = true;
            //}
        }
    }
}
