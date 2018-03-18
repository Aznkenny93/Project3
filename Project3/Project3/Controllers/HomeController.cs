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
        public HomeController()
        {
            _db = new Project3Context();
            User user = new User()
            {
                Name = "Henk",
                Description = "Ja"
            };
            _db.User.Add(user);
            _db.SaveChanges();
        }
        public ActionResult Index()
        {
            _db.User.ToList();
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

        private Project3Context _db = new Project3Context();
    }
}