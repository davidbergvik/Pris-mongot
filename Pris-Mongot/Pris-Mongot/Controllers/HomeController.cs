using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pris_Mongot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Welcome()
        {
            //TODO hämta username ur cookie eller db
            ViewBag.UserName = "Här ska vi skriva in ett användarnamn";

            //Hämta antal vunna/förlorade matcher ur DB
            ViewBag.Won = "5";
            ViewBag.Lost = "3";


            return View();
        }
    }
}