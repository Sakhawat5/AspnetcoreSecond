using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AspnetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly IConfiguration _configuration;
        public BooksController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var bookModel = new BookModel(_configuration);
            return View(bookModel);
        }

        public IActionResult GetBooks()
        {
            var tableModel = new DataTableAjaxRequestModel(Request);
            var model = new BookModel(_configuration);
            var data = model.GetBooks(tableModel);

            return Json(data);
        }
    }
}