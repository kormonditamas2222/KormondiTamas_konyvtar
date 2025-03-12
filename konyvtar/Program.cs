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
            Console.WriteLine(book1.GetBookByTitle(books, "Egri csillagok"));
            Console.WriteLine(book1.GetBookByTitle(books, "Gulliver utazásai"));
            foreach (Book book in books) { Console.WriteLine(book); }
            InputStuff();
            foreach (Book book in books) { Console.WriteLine(book); }
        }
        static void InputStuff()
        {
            int whichBook = -1;
            string choice = string.Empty;
            while (!(whichBook >= 0 && whichBook < books.Count))
            {
                Console.Write($"Melyik könyvet szeretnéd módosítani: (0-{books.Count - 1}) ");
                whichBook = Convert.ToInt32(Console.ReadLine());
            }
            while (!(choice == "author" || choice == "title" || choice == "pagecount" || choice == "releaseyear"))
            {
                Console.Write($"Melyik paraméterét szeretnéd megváltoztatni {books[whichBook].Title} könyvnek: (author, title, pagecount, releaseyear) ");
                choice = Console.ReadLine().ToLower();
            }
            if (choice == "author" || choice == "title")
            {
                Console.Write("Add meg az új értéket");
            }
            else if (choice == "pagecount" || choice == "releaseyear")
            {
                Console.Write("Add meg az új értéket (kérlek számban :>)");
            }
            string input = Console.ReadLine();
            books[0].EditBookData(books, whichBook, choice, input);
        }
    }
}
