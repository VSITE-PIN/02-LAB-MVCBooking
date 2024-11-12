using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models; 

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        // In-memory lista za pohranu podataka o bookingima (privremeno rješenje umjesto baze)
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        // 1. Prikaz svih bookinga
        public IActionResult Index()
        {
            return View(bookings);
        }

        // 2. Prikaz forme za kreiranje novog bookinga
        public IActionResult Create()
        {
            return View();
        }

        // 3. Kreiranje novog bookinga
        [HttpPost]
        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            if (ModelState.IsValid)
            {
                newBooking.Id = bookings.Count + 1; // Generiranje Id-a
                bookings.Add(newBooking);
                return RedirectToAction("Index");
            }
            return View("Create", newBooking);
        }
    }
}
