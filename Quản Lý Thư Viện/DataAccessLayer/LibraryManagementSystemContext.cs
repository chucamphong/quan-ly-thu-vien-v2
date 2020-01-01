using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LibraryManagementSystemContext : DbContext
    {
        public LibraryManagementSystemContext()
            : base("name=LibraryManagementSystemContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
