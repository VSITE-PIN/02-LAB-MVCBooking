using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> hotel = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(hotel);
        }
        public IActionResult Create()
        {
            HotelBooking hotel = new HotelBooking();
            return View(hotel);
        }
        public IActionResult CreateBooking(HotelBooking hotelViewModel)
        {
            hotel.Add(hotelViewModel);
            return RedirectToAction("Index");
        }
    }
}
