using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf { get; set; }
        private int _index { get; set; }

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }
        public bool HasNext()
        {
            if(_index<_bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
