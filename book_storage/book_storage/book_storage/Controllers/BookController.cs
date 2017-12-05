using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using book_storage.Models;

namespace book_storage.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult CreateBook()
        {
            var book = new Book();
            return View(book);
        }

        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                BaseTest.instance.AddBook(book);
            }
            else
            {
                ModelState.AddModelError("CreateBook", "Something wrong!");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
