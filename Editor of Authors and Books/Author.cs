using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_of_Authors_and_Books
{
    internal class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public DateTime Birthday { get; set; }

        public Author(string firstName, string lastName, string middleName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Birthday = birthday;
        }

        public Author() { }

    }
}
