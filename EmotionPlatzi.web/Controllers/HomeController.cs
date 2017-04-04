using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmotionPlatzi.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelcomeMessage = "Hola mundo";
            ViewBag.ValorEntero = 1;
            return View();
        }
    }
}