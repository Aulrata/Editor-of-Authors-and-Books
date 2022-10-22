using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_of_Authors_and_Books
{
    internal class ConnectBookAndAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public ConnectBookAndAuthor(int bookId, int authorId)
        {
            BookId = bookId;
            AuthorId = authorId;
        }
    }
}
