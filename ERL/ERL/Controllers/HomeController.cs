using ERL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERL.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult  Index([Bind(Include = "UserName, Password")] User user)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}