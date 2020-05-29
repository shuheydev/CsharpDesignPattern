using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        List<Book> _books = new List<Book>();
        int _last { get; set; } = 0;

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }

        public void AppendBook(Book book)
        {
            this._books.Add(book);
            _last++;
        }

        public int GetLength ()
        {
            return _last;
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }
    }
}
