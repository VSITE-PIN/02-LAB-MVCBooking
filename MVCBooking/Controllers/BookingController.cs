using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{

    public class BookingController : Controller
    {
        private static List<Booking> HotelBookings = new List<Booking>();
        private static int nextId = 1;
        public IActionResult Index()
        {
            return View(HotelBookings);
        }
        public IActionResult Create()
        {
            Booking hotelBooking = new Booking();
            return View(hotelBooking);
        }
        public IActionResult CreateBooking(Booking hotelBookingViewModel)
        {
            hotelBookingViewModel.Id = nextId++;
            HotelBookings.Add(hotelBookingViewModel);
            return RedirectToAction("Index");
        }
    }
}