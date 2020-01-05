using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataTransferObject;

namespace DataAccessLayer
{
    public class BookData : Data<Book>, IBookData
    {
        public IEnumerable<Book> SearchByNameOrAuthorOrPublisherOrCategory(string value)
        {
            return this.Entity.Where(book => book.Name.Contains(value) ||
                                             book.Authors.Any(author => author.Name.Contains(value)) ||
                                             book.Publisher.Name.Contains(value) ||
                                             book.Categories.Any(category => category.Name.Contains(value)));
        }

        public override void Update(Book book)
        {
            if (this.Context.Entry(book).State == EntityState.Detached)
            {
                this.Context.Books.Attach(book);
            }

            this.Context.Entry(book).State = EntityState.Modified;
        }
    }
}
