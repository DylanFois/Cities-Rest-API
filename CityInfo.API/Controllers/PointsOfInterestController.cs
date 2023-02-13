using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class PointsOfInterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
