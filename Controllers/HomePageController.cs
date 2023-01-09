using First_Checkpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Checkpoint.Controllers
{
    [Authorize]
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SideMenu()
        {
            List<MenuItems> list = new List<MenuItems>();
            list.Add(new MenuItems { Link = "/HomePage/Index", LinkName = "HomePage" });


            return PartialView("SideMenu", list);
        }
    }
}