using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using DataTransferObject;

namespace DataAccessLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManagementSystemContext>
    {
        private readonly List<Author> authors;
        private readonly List<Book> books;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;

            this.authors = this.AuthorsTableData();
            this.books = this.BooksTableData();
        }

        protected override void Seed(LibraryManagementSystemContext context)
        {
            context.Users.AddOrUpdate(new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = "123456" });

            context.Authors.AddRange(this.authors);

            context.Books.AddRange(this.books);

            context.SaveChanges();
        }

        private List<Author> AuthorsTableData()
        {
            return new List<Author> {
                new Author { Name = "Aoyama Goushou" },
                new Author { Name = "Fujiko Fujio" },
             };
        }

        private List<Book> BooksTableData()
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Name = "Thám tử lừng danh Conan",
                    Authors = this.authors.FindAll(c => c.Name.Equals("Aoyama Goushou")),
                },
                new Book
                {
                    Name = "Doraemon - Chú mèm máy đến từ tương lai",
                    Authors = this.authors.FindAll(c => c.Name.Equals("Fujiko Fujio")),
                },
            };

            return books;
        }
    }
}
