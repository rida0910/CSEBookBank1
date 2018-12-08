using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSEBookBank
{
    public class Booklist
    {
        List<Book> books = new List<Book>();
        public void addBook(string bookTitle, string bookAuthor, DateTime bookIssueDate) // adding book
        {
    //        books.Add(new Book(bookTitle, bookAuthor, bookIssueDate));
        }
        public void returnBook(string bookTitle) // returning a book 
        {
            books.RemoveAll(Book => Book.getTitle == bookTitle);
        }
    }
}