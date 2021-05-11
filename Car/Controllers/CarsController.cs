using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
      List<Car> allCars = new List<Car>() { volkswagen, yugo, ford, amc };
      return View(allCars);
    }
    [Route("/cars/price")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/cars/max")]
    public ActionResult Max(int userInput)
    {
      int maxPrice = userInput;
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> allCars = new List<Car>() { volkswagen, yugo, ford, amc };
      List<Car> CarsMatchingSearch = new List<Car>(0);
      foreach (Car automobile in allCars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      return View(CarsMatchingSearch);
    }
  }
}