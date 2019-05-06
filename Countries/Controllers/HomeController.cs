using Microsoft.AspNetCore.Mvc;
using Countries.Models;
using System.Collections.Generic;

namespace Countries.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Country> allCountries = new List<Country>();
      return View(allCountries);
    }

  }
}
