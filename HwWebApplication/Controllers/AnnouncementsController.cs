using Microsoft.AspNetCore.Mvc;
using HwWebApplication.Models;

namespace HwWebApplication.Controllers
{
  public class AnnouncementsController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
    
    [HttpGet]
    public IActionResult Add()
    {
      
      return View();
    }

    [HttpPost]
    public IActionResult Add(Announcement model)
    {
      if(ModelState.IsValid){
        Repository.CreateAnnouncement(model);
        return RedirectToAction("Index", "Home");
      }else{
        return View();
      }
    }

    [HttpGet]
    public IActionResult List()
    {
      return View(Repository.Announcements);
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
      return View(Repository.GetById(id));
    }
      
  }
}
