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
            HotelBooking hotel = new HotelBooking();
            return View(hotel);
        }
        public IActionResult CreateBooking(HotelBooking hotelModel)
        {
            bookings.Add(hotelModel);
            return RedirectToAction("Index");
        }
    }
}
