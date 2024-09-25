using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{

    public class BookingController : Controller
    {
        private static int autoId = 1;
        private static List<Booking> bookings = new List<Booking>();

        public IActionResult Index()
        {      
            return View(bookings);
        }
        public IActionResult Create()
        {
            Booking booking = new Booking();
            booking.Id = autoId++;
            return View(booking);
        }


        public IActionResult CreateBooking(Booking bookingViewModel)
        {
            
            bookings.Add(bookingViewModel);
            return RedirectToAction("Index");
        }

    }
}

