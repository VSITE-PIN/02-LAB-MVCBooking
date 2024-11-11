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

        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            newBooking.Id = bookings.Count;
            bookings.Add(newBooking);
            return RedirectToAction("Index");
        }
    }
}
