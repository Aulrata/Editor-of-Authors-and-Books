using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_of_Authors_and_Books
{
    class Service
    {
        public void Start()
        {

            AuthorContext db = new AuthorContext();

            Author author1 = new Author("Роман", "Бадьин", "Евгеньевич", new DateTime(2004,01,22));
            Author author2 = new Author("Роман1", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));
            Author author3 = new Author("Роман2", "Бадьин", "Евгеньевич", new DateTime(2004, 01, 22));

            var storageAuthors = new List<Author>() { author1, author2, author3};
            foreach (var item in storageAuthors)
            {
                db.Authors.Add(item);
            }
            db.SaveChanges();
            Console.WriteLine();
        }
    }
}
