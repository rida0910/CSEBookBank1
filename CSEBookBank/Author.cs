using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSEBookBank
{
    public class Author
    {
        private string Name;
        public List<Book> Books = new List<Book>();




        public Author()
        {
            this.Name = null;
            List<Book> courses = new List<Book>();
        }
    }
}