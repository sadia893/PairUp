using First_Checkpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Checkpoint.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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














        public ActionResult SideMenu()
        {
            List<MenuItems> list = new List<MenuItems>();
            list.Add(new MenuItems { Link= "/Home/Index",LinkName="Home" });
           

            return PartialView("SideMenu",list);
        }


        public ActionResult Footer()
        {
     


            return PartialView("Footer");
        }





    }
}