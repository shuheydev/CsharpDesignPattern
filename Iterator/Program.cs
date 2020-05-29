using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();

            bookShelf.AppendBook(new Book("書籍1"));

            Console.WriteLine(bookShelf.GetBookAt(0).Name);
        }
    }
}
