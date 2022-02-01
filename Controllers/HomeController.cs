using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //namespace que contém a classe Controller

namespace FirstWebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
