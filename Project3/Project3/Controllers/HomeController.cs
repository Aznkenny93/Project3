﻿using Project3.Models;
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
            //_db.Bus.Add(new Bus()
            //{
            //    RitNumber = 3,
            //    Bustime = "075400"
            //});
            //_db.SaveChanges();
            //_db.Bus.ToList();
            return View();
        }

        public ActionResult GetEvent(int id)
        {
            int m = id;
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