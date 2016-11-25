using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhongVeSkyline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Venoidia()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vequocte()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tintuc()
        {
            ViewBag.Message = "Your news page.";

            return View();
        }

        public ActionResult Gioithieu()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ActionResult Lienhe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}