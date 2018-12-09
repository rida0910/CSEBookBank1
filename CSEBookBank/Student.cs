using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSEBookBank
{
    public class Student
    {
        private string Name;
        private string RegistrationNumber;
        private string Password;
        public List<Book> books = new List<Book>();
       



        public Student()
        {
            this.Name = null;
            this.RegistrationNumber = null;
            this.Password = null;
            List< Book > books = new List<Book>();
        }

        public Student(string std_Name, string Reg_No, string password)
        {
            this.Name = std_Name;
            this.RegistrationNumber = Reg_No;
            this.Password = password;
        
        }
        
        public void addBook(string bookTitle, string bookAuthor,bool Issued, int bookQuantity)
        {
            string btitle;
            string bauthor;
            string bID;

            for (int x = 0; x <= bookQuantity; x++)
            {
              
                btitle = Console.ReadLine();

        
                bauthor = Console.ReadLine();


                bID = Console.ReadLine();

              //  books.Add(new  Book(btitle, bauthor,bID));
            }
        }
    }
}