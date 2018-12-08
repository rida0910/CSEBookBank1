using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSEBookBank
{
    public class Book
    {
        private string Title;
        private string ID;
        private string Author;
        private string Edition;
        private DateTime IssueDate;
        private DateTime ReturnDate;
    

        public Book()
        {
            this.Title = null;
            this.ID = null;
            this.Author = null;
            this.Edition = null;
            this.IssueDate = new DateTime();
            this.ReturnDate = new DateTime();

        }

        public Book(string booktitle, string bookID, string bookAuthor, string bookEdition,DateTime bookissuedate,DateTime bookreturndate )
        {
            this.Title = booktitle;
            this.ID = bookID;
            this.Author = bookAuthor;
            this.Edition = bookEdition;
            this.IssueDate = new DateTime();
            this.ReturnDate = new DateTime ();

        }


        public Book(Book book1)
        {
            this.Title = book1.Title;
            this.ID = book1.ID;
            this.Author = book1.Author;
            this.Edition = book1.Edition;
            this.IssueDate =book1.IssueDate;
            this.ReturnDate = book1.ReturnDate;
        }


        public string getTitle
        {
            get
            { 
                return Title;    
            }
            set
            {
               Title = value;
            }
        }
    
        public string getID { get; set; }
        public string getAuthor { get; set; }
        public int getEdition { get; set; }
        public DateTime getissuedate { get; set; }
        public DateTime getreturndate { get; set; }
        public bool Issued { get; set; }

    }
}
