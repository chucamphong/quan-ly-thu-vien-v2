using System.Data.Entity;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LibraryManagementSystemContext : DbContext
    {
        private static LibraryManagementSystemContext instance;

        public LibraryManagementSystemContext()
            : base("name=LibraryManagementSystemContext")
        {
        }

        public static LibraryManagementSystemContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LibraryManagementSystemContext();
                }

                return instance;
            }
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
