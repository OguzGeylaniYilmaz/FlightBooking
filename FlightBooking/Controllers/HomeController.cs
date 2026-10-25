using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
