using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerritStudy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //First Commit
            //Second Commit
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
