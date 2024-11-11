using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {

        private static List<HotelBooking> hotelBookings = new List<HotelBooking>();
        private static int _id = 1;

        public IActionResult Index()
        {
            return View(hotelBookings);
        }

        public IActionResult Create()
        {
            return View(new HotelBooking());
        }

        public IActionResult CreateBooking(HotelBooking newBooking) 
        {
            if (newBooking != null)
            {
                newBooking.Id = _id++;
                hotelBookings.Add(newBooking);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }

    }
}
