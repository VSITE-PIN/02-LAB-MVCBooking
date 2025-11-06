using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

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
            return View(new HotelBooking());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBooking(HotelBooking booking)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", booking);
            }

            booking.Id = bookings.Count == 0 ? 1 : bookings.Max(b => b.Id) + 1;
            bookings.Add(booking);
            return RedirectToAction(nameof(Index));
        }
    }
}
