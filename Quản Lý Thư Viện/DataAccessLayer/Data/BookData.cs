using System.Data.Entity;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public class BookData : Data<Book>
    {
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
