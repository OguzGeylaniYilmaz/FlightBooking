using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.BookingViewComponents
{
    public class _BookingTagsComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}