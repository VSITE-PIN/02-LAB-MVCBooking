using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Linq;

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
            return View(booking);
        }
        public IActionResult CreateBooking(HotelBooking bookingViewModel)
        {
            bookings.Add(bookingViewModel);
            return RedirectToAction("Index");
        }
    }
}
