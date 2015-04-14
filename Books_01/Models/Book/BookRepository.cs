using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Book
{
    public class BookRepository
    {
        List<Book> books;
        public BookRepository()
        {
            books=new List<Book>();
            books.Add(new Book("OPERATCIYA I","DONTSOVA",new DateTime(2002,2,2)));
            books.Add(new Book("ASDASD I", "Putin", new DateTime(2002, 2, 2)));
            books.Add(new Book("2dsadas I", "Pushkin", new DateTime(2002, 2, 2)));
        }
        public void deleteBook(int id)
        {
            books.RemoveAll(n => id == n.id);
        }
        // остальные методы потом добавлю, ЕПТ
        public IEnumerable<Book> getAllBooks()
        {
            return books.Select(n => n);
        }
    }
}