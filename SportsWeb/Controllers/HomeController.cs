using Microsoft.AdventureWorks.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsWeb.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAddressManager addressManager;

        public HomeController(IAddressManager addressManager)
        {
            this.addressManager = addressManager;
        }

        public ActionResult Index()
        {
            var address = addressManager.GetAll();    
            return View(address.ToList());
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
    }
}