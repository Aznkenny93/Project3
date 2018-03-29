using Project3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEvent(string id)
        {
            ViewBag.id = id;
            return View();
        }
        
        public ActionResult PlanReis(string id)
        {
            ViewBag.id = id;
            ViewBag.Parking = _db.Parking.ToList();
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        private Project3Context _db = new Project3Context();
    }
}