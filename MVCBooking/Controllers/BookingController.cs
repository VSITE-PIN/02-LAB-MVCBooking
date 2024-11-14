using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Security.AccessControl;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List <HotelBooking> bookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(bookings);
        }
        public IActionResult Create()
        {
            HotelBooking Booking = new HotelBooking();
            return View(Booking);
        }
        public IActionResult CreateBooking(HotelBooking BookingViewModel)
        {
            bookings.Add(BookingViewModel);
            return RedirectToAction("Index");
        }
    }
}
