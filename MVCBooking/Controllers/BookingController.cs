using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View(Bookings);
        }
        private static List<HotelBooking> Bookings = new List<HotelBooking>();
        public IActionResult Create()
        {
            HotelBooking booking = new HotelBooking();
            return View(booking);
        }
        public IActionResult CreateBooking(HotelBooking bookingViewModel)
        {
            Bookings.Add(bookingViewModel);
            return RedirectToAction("Index");
        }
    }
}
