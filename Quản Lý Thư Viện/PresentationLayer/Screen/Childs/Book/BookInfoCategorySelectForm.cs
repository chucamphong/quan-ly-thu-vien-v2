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
        private readonly ICollection<Category> categories = new HashSet<Category>();
        private readonly ICollection<Category> selectedCategories;

        public BookInfoCategorySelectForm(ICollection<Category> selectedCategories)
        {
            this.InitializeComponent();
            this.selectedCategories = selectedCategories;
        }

        public delegate void DelegateSendListCategories(ICollection<Category> categories);

        public DelegateSendListCategories SendListCategories { get; set; }

        private void BookInfoCategorySelectForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
            this.LoadAll();
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

        private void LoadAll()
        {
            this.authorBindingSource.DataSource = this.categoryService.All().ToList();

            foreach (DataGridViewRow row in this.dataGridView.Rows)
            {
                string name = row.Cells[1].Value.ToString();

                Category author = this.selectedCategories?.FirstOrDefault(selectedAuthor => selectedAuthor.Name == name);

                if (author != null)
                {
                    row.Cells[0].Value = true;
                }
            }

            this.dataGridView.RefreshEdit();
            this.dataGridView.Refresh();
        }
    }
}
