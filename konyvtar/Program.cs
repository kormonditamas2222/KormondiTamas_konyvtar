namespace konyvtar
{
    internal class Program
    {
        static List<Book> books = new();
        static void Main(string[] args)
        {
            Book book1 = new("Egri csillagok", "Gárdonyi Géza", 400, 1964);
            books.Add(book1);
            Book book2 = new("Harry Potter a Petrikben", "J. K. Rowling", 1000, 2025);
            books.Add(book2);
            Book book3 = new("A szürke ötven árnyalata", "nem tudom", 200, 2003);
            books.Add(book3);
        }
    }
}
