using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class AuthorService
    {
        private AuthorData authorData = new AuthorData();

        public async Task<IEnumerable<Author>> All()
        {
            return await Task.Run(() => this.authorData.All());
        }

        public IEnumerable<Author> FindByName(string name)
        {
            return this.authorData.FindBy(book => book.Name == name);
        }
    }
}
