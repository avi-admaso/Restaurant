using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;
namespace Restaurant.Controllers
{
    public class ChefController : Controller
    {
        public static List<Chef> theChefs = new List<Chef>() {

        new Chef(1, "AVI ADMASO", 26, "aviadmaso@gmail.com", 920000),
            new Chef(2, "shimon samay", 21, "shimonsamay@gmail.com", 18000),
            new Chef(3, "amir mangistu", 29, "amirmangistu@gmail.com", 1300),
            new Chef(4, "oshri zagay", 24, "oshrizagay@gmail.com", 1100),
            new Chef(5, "eliyahu belay", 27, "eliyahubelay@gmail.com", 4800),
        };


        // GET: Chef
        public ActionResult ShowChefName()
        {

            ViewBag.chefName = theChefs[4].fullName;
            return View();
        }
        public ActionResult ShowChef(int Id)
        {
            ViewBag.findChefById = theChefs.Find(chef => chef.Id == Id );
            return View();
        }
    }
}