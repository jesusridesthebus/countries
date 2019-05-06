using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace Countries.Controllers
{
  public class CountriesController : Controller
  {

    [HttpGet("/categories/{categoryId}/countries/new")]
    public ActionResult New(int categoryId)
    {
       Category category = Category.Find(categoryId);
       return View(category);
    }

    [HttpGet("/categories/{categoryId}/countries/{countryId}")]
    public ActionResult Show(int categoryId, int countryId)
    {
      Item country = Country.Find(itemId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category category = Category.Find(categoryId);
      model.Add("country", country);
      model.Add("category", category);
      return View(model);
    }

    [HttpPost("/countries/delete")]
    public ActionResult DeleteAll()
    {
      Country.ClearAll();
      return View();
    }

  }
}
