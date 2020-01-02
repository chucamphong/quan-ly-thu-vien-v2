using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public class AuthorData
    {
        private readonly LibraryManagementSystemContext context = LibraryManagementSystemContext.Instance;

        public IEnumerable<Author> All()
        {
            return this.context.Authors;
        }

        public Author FindById(int id)
        {
            return this.context.Authors.FirstOrDefault(book => book.Id == id);
        }

        public IEnumerable<Author> FindBy(Expression<Func<Author, bool>> filter)
        {
            return this.context.Authors.Where(filter);
        }
    }
}
