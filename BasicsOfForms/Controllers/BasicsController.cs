using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : Controller
    {
        // GET: Basics
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection sentForm)
        {
            // I like to see the values...
            ViewBag.emailAddress = sentForm["email"];
            ViewBag.password = sentForm["password"];
            ViewBag.passwordConf = sentForm["passwordconf"];

            int i = 0;

            return View();
        }

        // GET: Razor
        public ActionResult Razor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Razor(FormCollection sentForm)
        {
            // Again, I like to see the values...
            ViewBag.emailAddress = sentForm["email"];
            ViewBag.password = sentForm["password"];
            ViewBag.passwordConf = sentForm["passwordconf"];

            int i = 0;

            return View();
        }

        // GET: Angular
        public ActionResult Angular()
        {
            return View();
        }

    }
}