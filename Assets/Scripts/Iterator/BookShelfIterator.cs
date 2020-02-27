using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelfIterator : Iterator
{
    private BookShelf bookShelf;
    private int index;
    public BookShelfIterator(BookShelf bookShelf)
    {
        this.bookShelf = bookShelf;
        this.index = 0;
    }
    public bool HasNext()
    {
        if (index < bookShelf.GetLength())
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
        Book book = bookShelf.GetBookAt(index);
        index++;
        return book;
    }
}

