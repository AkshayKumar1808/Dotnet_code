namespace Entity_Framework.models
{
    public class Author
    {
        public int AuthorId {  get; set; }
        public string AuthorName {  get; set; }
        public string AuthorEmail { get; set; }

        List<Book> listBook { get; set; }

    }
}
