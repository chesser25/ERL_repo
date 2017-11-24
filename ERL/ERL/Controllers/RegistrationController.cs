using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERL.Models;

namespace ERL.Controllers
{
    public class RegistrationController : Controller
    {
        private UsersDBEntities1 db = new UsersDBEntities1();

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,UserName,Email,ContactNo,Password,CompanyName")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.UserInfoes.Add(new UserInfo {Id = user.Id });
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

    }
}
