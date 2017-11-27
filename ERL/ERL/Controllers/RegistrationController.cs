using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERL.Models;
using ERL.Mail;

namespace ERL.Controllers
{
    public class RegistrationController : Controller
    {
        private UsersDBEntities db = new UsersDBEntities();
        
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
                db.SaveChanges();
                MailHelper.GetMailHelper.Setup();
                return Redirect("Home/Index");
            }
            return View(user);
            
        }

    }
}
