using Newtonsoft.Json;
using Project3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
            List<Parking> parking = _db.Parking.ToList();

            List<dynamic> parkingDynamic = new List<dynamic>();
            foreach (var item in parking)
            {
                dynamic parkingspot = new { lat = item.Latitude, lng = item.Longitude };
                parkingDynamic.Add(parkingspot);
            }
            ViewBag.ParkingList = JsonConvert.SerializeObject(parkingDynamic);
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        private Project3Context _db = new Project3Context();
    }
}