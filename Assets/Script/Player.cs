using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BookShelf bookShelf = new BookShelf(4);

        bookShelf.AppendBook(new Book("Apple"));
        bookShelf.AppendBook(new Book("Orange"));
        bookShelf.AppendBook(new Book("Strawberry"));
        bookShelf.AppendBook(new Book("Lemon"));

        Iterator it = bookShelf.Iterator();

        while (it.HasNext())
        {
            Book book = (Book)it.Next();
            Debug.Log(book.GetName());
        }
    }
}

