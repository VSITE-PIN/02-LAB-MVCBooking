using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;
using MVCBooking.Models;

namespace YourNamespace.Controllers
{
    public class BookingController : Controller
    {
        // Staticka lista za čuvanje booking podataka u memoriji
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        // Prikazivanje svih booking-a
        public IActionResult Index()
        {
            return View(bookings); // Vraća sve booking-e u Index view
        }

        // Prikazivanje forme za kreiranje novog booking-a
        public IActionResult Create()
        {
            return View();
        }

        // Dodavanje novog booking-a
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            if (ModelState.IsValid)
            {
                // Dodavanje novog booking-a u memorijsku listu
                bookings.Add(newBooking);

                // Nakon dodavanja, preusmeravamo na Index gde će se videti svi booking-i
                return RedirectToAction("Index");
            }

            // Ako validacija ne uspe, vraćamo korisnika na formu s postojećim podacima
            return View("Create", newBooking);
        }
    }
}
