using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.WinForms;
using PresentationLayer.Screen.Childs;

namespace PresentationLayer.Screen
{
    public partial class BookScreen : Form
    {
        private readonly BookService bookService = new BookService();

        public BookScreen()
        {
            this.InitializeComponent();
        }

        private void BookScreen_Load(object sender, EventArgs e)
        {
            this.LoadAll();
        }

        private async void LoadAll()
        {
            this.BindGrid(await this.bookService.All());
        }

        // Tạo placeholder cho txtSearch
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            Control txtSearch = (Control)sender;
            string text = txtSearch.Text.Trim();

            if (text == "Nhập tên sách cần tìm...")
            {
                ((Control)sender).Text = string.Empty;
            }
        }

        // Tạo placeholder cho txtSearch
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            Control txtSearch = (Control)sender;
            string text = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                txtSearch.Text = "Nhập tên sách cần tìm...";
            }
        }

        /// <summary>
        /// Thực hiện tìm kiếm sách theo tên.
        /// </summary>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string name = (sender as Control).Text;

            // Nếu xóa hết thì khỏi cần bấm Enter
            if (string.IsNullOrEmpty(name))
            {
                this.LoadAll();
                return;
            }

            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            // Tìm kiếm
            var entities = this.bookService.SearchByName(name).ToList();

            if (entities.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.BindGrid(entities);
            }
        }

        private void BindGrid(IEnumerable<Book> books)
        {
            this.bindingSource.DataSource = books.ToList();
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

        private void SeeMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = (Book)this.dataGridView.SelectedRows[0].DataBoundItem;
            new BookInfoForm(book.Id).ShowDialog();
            this.LoadAll();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            new InsertBookForm().ShowDialog();
            this.LoadAll();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = (Book)this.dataGridView.SelectedRows[0].DataBoundItem;

            this.bookService.Delete(book);

            this.LoadAll();
        }
    }
}
