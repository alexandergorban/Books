using Books.Entities;
using System.Data.Entity;

namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}