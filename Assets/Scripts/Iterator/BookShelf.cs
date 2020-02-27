using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BookShelf : Aggregate
{
    private Book[] books;
    private int last = 0;
    public BookShelf(int maxsize)
    {
        this.books = new Book[maxsize];
    }
    public Book GetBookAt(int index)
    {
        return books[index];
    }
    public void AppendBook(Book book)
    {
        this.books[last] = book;
        last++;
    }
    public int GetLength()
    {
        return last;
    }
    public Iterator Iterator()
    {
        return new BookShelfIterator(this);
    }

}

