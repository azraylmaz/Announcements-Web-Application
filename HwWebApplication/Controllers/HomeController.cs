using Microsoft.AspNetCore.Mvc;
using HwWebApplication.Models;

namespace Homework1.Controllers{
    public class HomeController : Controller {
        public IActionResult Index(){

            int hour = DateTime.Now.Hour;
            ViewData["Greeting"] = hour > 12 ? "Good Afternoon" : "Good Morning";
            ViewData["Date"] = DateTime.Now;

            ViewBag.Count = Repository.Announcements.Count;

           return View(Repository.Announcements);
        }
    }
}