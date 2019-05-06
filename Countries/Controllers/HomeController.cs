using Microsoft.AspNetCore.Mvc;
using Countries.Models;

namespace Countries.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
   {
     Item starterItem = new Item("Add first item to To Do List");
     return View(starterItem);
   }

  }
}
