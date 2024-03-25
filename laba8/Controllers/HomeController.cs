using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using laba8.Models;
namespace laba8.Controllers
{
    public class HomeController : Controller
    {
        List<ProductsModel> list1 = new List<ProductsModel>()
        {
            new ProductsModel(1, "Pizza", 135, new DateOnly(2022, 10, 20)),
            new ProductsModel(2, "Milk", 40, new DateOnly(2022, 09, 27)),
            new ProductsModel(3, "Eggs", 60, new DateOnly(2022, 11, 03)),
            new ProductsModel(4, "Cheese", 85, new DateOnly(2022, 11, 01))
        };
        public IActionResult Index()
        {
            return View(list1);
        }
    }
}
