using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Editor_of_Authors_and_Books
{
    internal class AuthorContext : DbContext
    {
        public AuthorContext(): base("DbConnection") { }

        public DbSet<Author> Authors { get; set; }
    }
}
