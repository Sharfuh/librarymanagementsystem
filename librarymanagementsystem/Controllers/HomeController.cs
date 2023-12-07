using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace librarymanagementsystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the Library Management System. This application helps you manage books, members, and transactions.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you have any questions or need assistance, feel free to contact us.";

            return View();
        }
    }
}
