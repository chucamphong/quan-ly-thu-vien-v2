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
            string password = "e10adc3949ba59abbe56e057f20f883e";

            context.Users.AddOrUpdate(new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = password });

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
            Customer nguyenVanA = new Customer
            {
                Name = "Nguyễn Văn A",
                Email = "nguyenvana@gmail.com",
                Birthday = new DateTime(1999, 08, 24),
                Phone = "0938997287",
                Address = "Nhà quận 1",
            };

            nguyenVanA.Books = new List<CustomerBooks>
            {
                new CustomerBooks
                {
                    Book = this.books.Find(book => book.Name == "Thám tử lừng danh Conan"),
                    Customer = nguyenVanA,
                    From = DateTime.Now,
                    To = DateTime.Now.AddDays(2),
                },
                new CustomerBooks
                {
                    Book = this.books.Find(book => book.Name == "Doraemon - Chú mèm máy đến từ tương lai"),
                    Customer = nguyenVanA,
                    From = DateTime.Now,
                    To = DateTime.Now.AddDays(2),
                    Date_Returned = DateTime.Now.AddDays(3),
                },
            };

            return new List<Customer>
            {
                nguyenVanA,
                new Customer
                {
                    Name = "Nguyễn Văn B",
                    Email = "nguyenvanb@gmail.com",
                    Birthday = new DateTime(1889, 12, 02),
                    Phone = "01234454399",
                    Address = "Nhà quận 2",
                },
            };
        }
    }
}
