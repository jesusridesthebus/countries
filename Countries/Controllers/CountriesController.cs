using Microsoft.AspNetCore.Mvc;
using Countries.Models;
using System.Collections.Generic;

namespace Countries.Controllers
{
  public class CountriesController : Controller
  {

    [HttpGet("/countries")]
    public ActionResult Index()
    {
       //List<Country> viewCountry = Country.GetAll();
       return View();
    }

    [HttpGet("/countries/{countryId}")]
    public ActionResult Show(string countryId)
    {
      Country country = Country.Find(countryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("country", country);
      return View(model);
    }

    [HttpPost("/countries/delete")]
    public ActionResult DeleteAll()
    {
      //Country.ClearAll();
      return View();
    }

  }
}
