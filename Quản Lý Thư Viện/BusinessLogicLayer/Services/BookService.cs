using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class BookService
    {
        private readonly BookData bookData = new BookData();

        public async Task<IEnumerable<Book>> All()
        {
            return await Task.Run(() => this.bookData.All());
        }

        public Book Find(int id)
        {
            return this.bookData.FindBy(book => book.Id == id).FirstOrDefault();
        }

        public IEnumerable<Book> FindByName(string name)
        {
            return this.bookData.FindBy(book => book.Name.Contains(name));
        }

        public void Update(Book book)
        {
            this.bookData.Update(book);
            this.bookData.Save();
        }
    }
}
