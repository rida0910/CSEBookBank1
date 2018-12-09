﻿using CSEBookBank.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CSEBookBank.Controllers
{
    [Authorize(Roles = "Student")]
    public class HomeController : Controller
    {
        private CSEBookBankDbEntities db = new CSEBookBankDbEntities();
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Book> list = new List<Book>();
            var books = db.Books;
            foreach (Book b in books)
            {
                if (b.IssuedTo == null)
                {
                    list.Add(b);
                }
            }
            return View(list);
        }

        public ActionResult IssueBook(int? id)
        {
           
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IssueBook(int id)
        {
            string UsrName = User.Identity.GetUserName();
            Book b = new Book();
            b = db.Books.Find(id);
            String title = b.Title;
            Request Rqst = new Request();
            Rqst.RqstMessage = UsrName + " Wants to issue " + title + " " + id;
            Rqst.BookID = b.BookID;
            Rqst.UserName = UsrName;
            db.Requests.Add(Rqst);
            db.SaveChanges();
            return RedirectToAction("index");

        }

        public ActionResult ReturnBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReturnBook(int id)
        {
            string UsrName = User.Identity.GetUserName();
            Book b = new Book();
            b = db.Books.Find(id);
            String title = b.Title;
            Request Rqst = new Request();
            Rqst.RqstMessage = UsrName + " Wants to return " + title + " " + id;
            Rqst.BookID = b.BookID;
            Rqst.UserName = UsrName;
            db.Requests.Add(Rqst);
            db.SaveChanges();
            return RedirectToAction("index");

        }

        public ActionResult MyBooks()
        {
            List<Book> list = new List<Book>();
            foreach(Book book in db.Books)
            {
                if (book.IssuedTo == User.Identity.GetUserName())
                {
                    list.Add(book);
                }
            }
            return View(list);
        }

        

        public ActionResult History()
        {
            List<History> list = new List<History>();
            foreach (History h in db.Histories)
            {
                if (h.StudentName == User.Identity.GetUserName())
                {
                    list.Add(h);
                }
            }
            return View(list);
        }
        public ActionResult Notifications()
        {

            List<Notification> list = new List<Notification>();
            foreach (Notification not in db.Notifications)
            {
                if (not.UserName == User.Identity.GetUserName())
                {
                    list.Add(not);
                }
            }
            return View(list);
        }
        public ActionResult Search(string SearchString)
        {
            return View(db.Books.Where(x => x.Title.StartsWith(SearchString)).ToList());
        }
    }
}