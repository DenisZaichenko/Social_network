using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_01.Models.Book;

namespace Books_01.Controllers
{
    public class BooksController:Controller
    {
        BookRepository _repo;
        public BooksController()
        {
            _repo =new BookRepository();
        }

        public ActionResult Books()
        {
            return View(_repo);
        }

    }
}