using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_of_Authors_and_Books
{
    internal class Book
    {
        public int BookID { get; set; }

        public string Name { get; set; }

        public int YearOfIssue { get; set; }

        public List<int> AuthorsList { get; set; }

        public Book(string name, int yearOfIssue)
        {
            Name = name;
            YearOfIssue = yearOfIssue;
        }

        public Book() { }
    }
}
