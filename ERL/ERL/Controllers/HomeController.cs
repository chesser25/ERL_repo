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
        private UsersDBEntities1 db = new UsersDBEntities1();
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
                if(IsUserExist(user))
                {

                }
            }
            return View(user);
        }

        bool IsUserExist(User _user)
        {
            //    User user = db.Users.Find();
            //    if (user == null)
            //        return false;
            //    return true;
            return false;
        }
    }
}