using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            DashboardModel dashboardModel = new DashboardModel();
            dashboardModel.MenuModel = new MenuModel();
            return View(dashboardModel);
        }
    }
}