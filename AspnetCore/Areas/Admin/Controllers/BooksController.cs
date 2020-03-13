using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var bookModel = new BookModel();
            return View(bookModel);
        }

        public IActionResult GetBooks()
        {
            var tableModel = new DataTableAjaxRequestModel(Request);
            var model = new BookModel();
            var data = model.GetBooks(tableModel);

            return Json(data);
        }
    }
}