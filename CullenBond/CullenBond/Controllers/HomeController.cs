using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CullenBond.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "My name is Cullen";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A few things worth mentioning.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you'd like.";

            return View();
        }

        public ActionResult Gplus()
        {
            return View();
        }
    }
}
