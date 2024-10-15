using Entity_Framework.models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework.Repository
{
    public class AuthorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Entity;Integrated Security=True;");
        }
       public DbSet<Author> Authors {  get; set; }   
       public DbSet<Book> Books { get; set; }
    }
}
