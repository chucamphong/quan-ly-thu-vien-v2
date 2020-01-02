using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public class BookData
    {
        private LibraryManagementSystemContext context = LibraryManagementSystemContext.Instance;

        public IEnumerable<Book> All()
        {
            return this.context.Books;
        }

        public Book FindById(int id)
        {
            return this.context.Books.FirstOrDefault(book => book.Id == id);
        }

        public IEnumerable<Book> FindBy(Expression<Func<Book, bool>> filter)
        {
            return this.context.Books.Where(filter);
        }

        public void Update(Book book)
        {
            this.context.Books.Attach(book);
            this.context.Entry(book).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
