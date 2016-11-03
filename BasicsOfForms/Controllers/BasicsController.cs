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
        public ActionResult Index(FormCollection form)
        {
            ViewBag.formEmail = form["email"];
            ViewBag.formPassword = form["password"];
            ViewBag.formPasswordConf = form["password-conf"];

            return View();
        }
    }
}