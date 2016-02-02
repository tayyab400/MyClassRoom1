using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClassRoom.Models;

namespace MyClassRoom.Controllers
{
   
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Home

        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult gallery()
        {
            ViewBag.Title = "Gallery";
            return View("gallery");
        }
        public ActionResult basicGrid()
        {
            ViewBag.Title = "Basic Grid";
            return View("basicGrid");
        }
        public ActionResult fullWidth()
        {
            ViewBag.Title = "Full Width";
            return View("fullWidth");
        }
        public ActionResult sideBarLeft()
        {
            ViewBag.Title = "Side Bar";
            return View("sideBarLeft");
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View("Login");
        }
        [HttpPost]
        public ActionResult LoginConfirm(Login lg1)
        {
            var us = from m in db.Logins
                         select m;
           
            if (!String.IsNullOrEmpty(lg1.user.ToString()))
            {
                us = us.Where(s => s.user.Contains(lg1.user.ToString()));
                return View("Index");
            }
            return View("Login");
            
        }
    }
}