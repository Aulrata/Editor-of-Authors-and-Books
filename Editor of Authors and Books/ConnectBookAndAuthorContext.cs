using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Editor_of_Authors_and_Books
{
    internal class ConnectBookAndAuthorContext : DbContext
    {
        public ConnectBookAndAuthorContext() : base("DbConnection") { }

        public DbSet<ConnectBookAndAuthor> ConnectBooksAndAuthors { get; set; }
    }
}
