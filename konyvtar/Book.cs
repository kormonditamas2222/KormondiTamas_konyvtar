using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar
{
    internal class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int releaseYear;

        public Book(string title, string author, int pageCount, int releaseYear)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.releaseYear = releaseYear;
        }

        public string Title { get => title; }
        public string Author { get => author; }
        public int PageCount { get => pageCount; }
        public int ReleaseYear { get => releaseYear; }
        static void GetBookByTitle(List<Book> books, string title)
        {
            foreach (var item in books)
            {
                if (item.Title == title)
                {
                    Console.WriteLine($"{item.Title} könyv, írta: {item.Author}, {item.PageCount} hosszú, kiadási éve: {item.ReleaseYear}");
                }
            }
        }
        static void EditBookData()
        {

        }
    }
}
