using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class BookInfoAuthorSelectForm : Form
    {
        private readonly AuthorService authorService = new AuthorService();
        private readonly ICollection<Author> authors = new HashSet<Author>();
        private readonly ICollection<Author> selectedAuthors;

        public BookInfoAuthorSelectForm(ICollection<Author> selectedAuthors)
        {
            this.InitializeComponent();
            this.selectedAuthors = selectedAuthors;
        }

        public delegate void DelegateSendListAuthors(ICollection<Author> authors);

        public DelegateSendListAuthors SendListAuthors { get; set; }

        private void BookInfoAuthorSelectForm_Load(object sender, EventArgs e)
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

            Author author = (Author)this.dataGridView.Rows[e.RowIndex].DataBoundItem;

            bool @checked = Convert.ToBoolean(this.dataGridView.Rows[e.RowIndex].Cells[0].Value);

            if (@checked)
            {
                this.authors.Add(author);
            }
            else
            {
                this.authors.Remove(author);
            }

            this.SendListAuthors(this.authors);
        }

        private void LoadAll()
        {
            this.authorBindingSource.DataSource = this.authorService.All().ToList();

            foreach (DataGridViewRow row in this.dataGridView.Rows)
            {
                string name = row.Cells[1].Value.ToString();

                Author author = this.selectedAuthors?.FirstOrDefault(selectedAuthor => selectedAuthor.Name == name);

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
