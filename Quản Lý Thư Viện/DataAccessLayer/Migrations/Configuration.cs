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
        private readonly List<Category> categories;
        private readonly List<Publisher> publishers;
        private readonly List<Customer> customers;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;

            this.authors = this.AuthorsTableData();
            this.categories = this.CategoriesTableData();
            this.publishers = this.PublishersTableData();
            this.books = this.BooksTableData();
            this.customers = this.CustomersTableData();
        }

        protected override void Seed(LibraryManagementSystemContext context)
        {
            context.Users.AddOrUpdate(new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = "123456" });

            context.Authors.AddRange(this.authors);

            context.Categories.AddRange(this.categories);

            context.Publishers.AddRange(this.publishers);

            context.Books.AddRange(this.books);

            context.Customers.AddRange(this.customers);

            context.SaveChanges();
        }

        private List<Author> AuthorsTableData()
        {
            return new List<Author>
            {
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
                    Authors = this.authors.FindAll(a => a.Name.Equals("Aoyama Goushou")),
                    Categories = this.categories.FindAll(c => c.Name.Equals("Trinh thám")),
                    Publisher = this.publishers.Find(p => p.Name.Equals("Nhà xuất bản Kim Đồng")),
                },
                new Book
                {
                    Name = "Doraemon - Chú mèm máy đến từ tương lai",
                    Authors = this.authors.FindAll(a => a.Name.Equals("Fujiko Fujio")),
                    Categories = this.categories.FindAll(c => c.Name.Equals("Hành động")),
                    Publisher = this.publishers.Find(p => p.Name.Equals("Viz Media")),
                },
            };

            return books;
        }

        private List<Category> CategoriesTableData()
        {
            return new List<Category>
            {
                new Category { Name = "Trinh thám" },
                new Category { Name = "Hành động" },
            };
        }

        private List<Publisher> PublishersTableData()
        {
            return new List<Publisher>
            {
                new Publisher { Name = "Nhà xuất bản Kim Đồng" },
                new Publisher { Name = "Viz Media" },
                new Publisher { Name = "Funimation" },
            };
        }

        private List<Customer> CustomersTableData()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Name = "Nguyễn Văn A",
                    Email = "nguyenvana@gmail.com",
                    Birthday = new DateTime(1999, 08, 24),
                },
                new Customer { Name = "Nguyễn Văn B", Email = "nguyenvanb@gmail.com", Birthday = new DateTime(1889, 12, 02) },
            };
        }

        private List<CustomerBooks> CustomerBooksTableData()
        {
            return new List<CustomerBooks>
            {
                new CustomerBooks
                {
                    Book = this.books.Find(book => book.Id == 1),
                    Customer = this.customers.Find(customer => customer.Id == 1),
                    From = DateTime.Now,
                    To = DateTime.Now.AddDays(2),
                },
            };
        }
    }
}
