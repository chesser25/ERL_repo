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
                Check(user);
            }
            return View();
        }

        void Check(User _user)
        {
            UsersDBEntities1 db = new UsersDBEntities1();
            User user = db.Users.Find(_user.UserName);
            if (user == null)
            {
                Index();
            }
            else
            {
                int userId = user.Id;
                string redirectUri = Url.Action("Edit", "Info", userId);
                Redirect(redirectUri);
            }
        }
    }
}