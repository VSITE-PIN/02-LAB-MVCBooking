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
            HotelBooking hotelBooking = new HotelBooking(); 

            return View(hotelBooking);
        }

        [HttpPost]
        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            bookings.Add(newBooking);
            return RedirectToAction("Index");
        }
    }
}
