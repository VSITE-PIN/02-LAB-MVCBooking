using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        // Index metoda za prikaz svih bookinga
        public IActionResult Index()
        {
            return View(bookings);
        }

        // Create metoda za prikaz Create view-a
        public IActionResult Create()
        {
            return View();
        }

        // CreateBooking metoda za dodavanje novog bookinga
        [HttpPost]
        public IActionResult CreateBooking(HotelBooking booking)
        {
            if (ModelState.IsValid)
            {
                bookings.Add(booking);
                return RedirectToAction("Index");
            }
            return View("Create");
        }
    }
}

