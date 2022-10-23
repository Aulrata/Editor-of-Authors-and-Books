using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Editor_of_Authors_and_Books
{
    class Service
    {
        BookContext _dbBooks;
        AuthorContext _dbAuthors;

        public Service()
        {
            _dbAuthors = new AuthorContext();
            _dbBooks = new BookContext();
        }

        //public void Start()
        //{

            

        //    //Author author1 = new Author("Роман", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));
        //    //Author author2 = new Author("Роман1", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));
        //    //Author author3 = new Author("Роман2", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));

        //    //var storageAuthors = new List<Author>() { author1, author2, author3 };
        //    //foreach (var item in storageAuthors)
        //    //{
        //    //    _dbAuthors.Authors.Add(item);
        //    //}
        //    //_dbAuthors.SaveChanges();
        //    //Console.WriteLine();

             

        //    //Book book = new Book("Война и мир", 2004);
        //    //Book book1 = new Book("Преступление и наказание",2005);
        //    //Book book2 = new Book("Ромео и Джульетта", 2004);

        //    //var storageBook = new List<Book>() { book1, book2, book };

        //    //foreach (var item in storageBook)
        //    //{
        //    //    _dbBooks.Books.Add(item);
        //    //}
        //    //_dbBooks.SaveChanges();

        //}
        public DbSet<Author> ShowAuthors()
        {
            return _dbAuthors.Authors;
        }

        public DbSet<Book> ShowBooks()
        {
            return _dbBooks.Books;
        }

        public void AddAuthor(string lastName, string firstName, string middleName, string birtday)
        {
            try
            {
                string[] args = birtday.Split('.');
                _dbAuthors.Authors.Add(new Author (firstName, lastName, middleName, new DateTime(int.Parse(args[2]), int.Parse(args[1]), int.Parse(args[0]))));
                _dbAuthors.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddBook(string name, int yearOfIssue)
        {
            try
            {
                _dbBooks.Books.Add(new Book(name, yearOfIssue));
                _dbBooks.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveAuthor(int id)
        {
            try
            {
                Author author= _dbAuthors.Authors.FirstOrDefault(e => e.AuthorID == id);
                _dbAuthors.Authors.Remove(author);
                _dbAuthors.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveBook(int id)
        {
            try
            {
                Book book = _dbBooks.Books.FirstOrDefault(e=>e.BookID == id);
                _dbBooks.Books.Remove(book);
                _dbBooks.SaveChanges ();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
