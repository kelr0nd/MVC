using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using book_storage.Models;

namespace book_storage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            BaseTest.instance.Books.Sort();
            var books = BaseTest.instance.Books;
            return View(books);
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Details(int Id = 1)
        {
            var book = BaseTest.instance.Books.FirstOrDefault(x => x.Id == Id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult EditBook(int Id)
        {
            var book = BaseTest.instance.Books.FirstOrDefault(x => x.Id == Id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            BaseTest.instance.Books.RemoveAll(x => x.Id == book.Id);
            BaseTest.instance.Books.Add(book);
            return RedirectToAction("Details", "Home", new { id = book.Id });
        }

    }
}
