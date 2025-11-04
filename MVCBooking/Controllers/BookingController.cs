using MVCBooking.Models;
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
            HotelBooking booking = new HotelBooking();
            return View(new HotelBooking());
        }

        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            if (!ModelState.IsValid) return View("Create", newBooking);
            bookings.Add(newBooking);
            return RedirectToAction("Index");
        }
    }
}
