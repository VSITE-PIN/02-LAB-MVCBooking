using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models; // prilagodi po potrebi

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        // privremena "baza" u memoriji
        private static readonly List<HotelBooking> _bookings = new();

        // GET: /Booking
        public IActionResult Index()
        {
            return View(_bookings);
        }

        // GET: /Booking/Create
        public IActionResult Create()
        {
            return View(new HotelBooking());
        }

        // POST: /Booking/CreateBooking
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBooking(HotelBooking booking)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", booking);
            }

            booking.Id = _bookings.Count == 0 ? 1 : _bookings.Max(b => b.Id) + 1;
            _bookings.Add(booking);
            return RedirectToAction(nameof(Index));
        }
    }
}
