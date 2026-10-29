using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.HomeViewComponents
{
    public class _SliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
