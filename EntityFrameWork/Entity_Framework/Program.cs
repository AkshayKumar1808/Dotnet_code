using Entity_Framework.models;
using Entity_Framework.Service;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework
{
    public class Program
    {
        public static void Main(string[] args)
        {
          ImplofBook imp=new ImplofBook();
            //Add the book inside the db as well as due to eager loading we add author also
            Book book = new Book()
            {
                Title = "Test",
                Author = new Author
                {
                  
                    AuthorName = "Vidya",
                    AuthorEmail = "chutyaa@gmail.com"
                }
            };
            imp.AddBook(book);

            //Dispaly the data.
           List<Book> list=imp.DisplayBook();
            foreach(Book b in list)
            {
                Console.WriteLine(b.Title);
            }

        }
    }
}
