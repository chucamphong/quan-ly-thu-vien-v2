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
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class BookInfoCategorySelectForm : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        private readonly List<Category> categories = new List<Category>();
        private readonly ICollection<Category> selectedCategories;

        public BookInfoCategorySelectForm(ICollection<Category> selectedCategories)
        {
            this.InitializeComponent();
            this.selectedCategories = selectedCategories;
        }

        public delegate void DelegateSendListCategories(List<Category> authors);

        public DelegateSendListCategories SendListCategories { get; set; }

        private void BookInfoCategorySelectForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
            this.LoadAll();
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            Control txtSearch = sender as Control;
            txtSearch.Text = string.Empty;
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            Control txtSearch = sender as Control;

            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = "Tìm kiếm thể loại...";
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string name = (sender as Control).Text;

            if (string.IsNullOrEmpty(name))
            {
                this.LoadAll();
            }
            else
            {
                var authors = (IList<Author>)this.categoryService.FindByName(name);

                if (authors.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.authorBindingSource.DataSource = authors;
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Category category = (Category)this.dataGridView.Rows[e.RowIndex].DataBoundItem;

            bool @checked = Convert.ToBoolean(this.dataGridView.Rows[e.RowIndex].Cells[0].Value);

            if (@checked)
            {
                this.categories.Add(category);
            }
            else
            {
                this.categories.Remove(category);
            }

            this.SendListCategories(this.categories);
        }

        private async void LoadAll()
        {
            this.authorBindingSource.DataSource = (await this.categoryService.All()).ToList();

            foreach (DataGridViewRow row in this.dataGridView.Rows)
            {
                string name = row.Cells[1].Value.ToString();

                Category author = this.selectedCategories.FirstOrDefault(selectedAuthor => selectedAuthor.Name == name);

                if (author != null)
                {
                    row.Cells[0].Value = true;
                }
            }
        }
    }
}
