using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            MenuModel menu = new MenuModel();
            return View(menu);
        }
    }
}