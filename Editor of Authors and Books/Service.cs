using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_of_Authors_and_Books
{
    class Service
    {
        BookContext _dbBooks;
        AuthorContext _dbAuthors;
        public void Start()
        {

            _dbAuthors = new AuthorContext();

            Author author1 = new Author("Роман", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));
            Author author2 = new Author("Роман1", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));
            Author author3 = new Author("Роман2", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));

            var storageAuthors = new List<Author>() { author1, author2, author3 };
            foreach (var item in storageAuthors)
            {
                _dbAuthors.Authors.Add(item);
            }
            _dbAuthors.SaveChanges();
            Console.WriteLine();

             _dbBooks = new BookContext();

            Book book = new Book("Война и мир", 2004);
            Book book1 = new Book("Преступление и наказание",2005);
            Book book2 = new Book("Ромео и Джульетта", 2004);

            var storageBook = new List<Book>() { book1, book2, book };

            foreach (var item in storageBook)
            {
                _dbBooks.Books.Add(item);
            }
            _dbBooks.SaveChanges();

        }

        public DbSet<Book> ShowBooks()
        {
            return _dbBooks.Books;
        }

        public DbSet<Author> ShowAuthors()
        {
            return _dbAuthors.Authors;
        }
    }
}
