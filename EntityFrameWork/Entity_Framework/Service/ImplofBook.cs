using Entity_Framework.models;
using Entity_Framework.Repository;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework.Service
{
    public class ImplofBook
    {
        private AuthorContext authorContext;
        public ImplofBook() {
            authorContext = new AuthorContext();

        }
        public void AddBook(Book book)
        {
            authorContext.Books.Add(book);
            authorContext.SaveChanges();
        }
        public List<Book> DisplayBook()
        {
           var books = authorContext.Books.ToList();
            if(books!=null ) 
            { 
                return books;
            }
            throw new Exception("No data is available"); ;
        }

    }
}
