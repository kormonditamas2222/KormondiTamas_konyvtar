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
            string dolog = book1.ToString();
            Console.WriteLine();
            foreach (Book book in books) { Console.WriteLine(book); }
            InputStuff(books);
        }
        static void InputStuff(List<Book> books)
        {
            int whichBook = -1;
            while (!(whichBook >= 0 && whichBook < books.Count))
            {
                Console.Write($"Melyik könyvet szeretnéd módosítani: (0-{books.Count - 1}) ");
                whichBook = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
