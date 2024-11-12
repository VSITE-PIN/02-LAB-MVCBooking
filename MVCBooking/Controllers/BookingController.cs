using Microsoft.AspNetCore.Mvc;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> bookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(bookings);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateBooking(HotelBooking booking)
        {
            if (ModelState.IsValid)
            {
                booking.Id = bookings.Count + 1;
                bookings.Add(booking);
                return RedirectToAction("Index");
            }
            return View("Create");
        }
    }
}
