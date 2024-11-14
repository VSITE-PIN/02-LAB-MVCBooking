using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        // Akcija za prikaz svih rezervacija
        public IActionResult Index()
        {
            var bookings = new List<HotelBooking>
            {
                new HotelBooking { Id = 1, GuestName = "Ana", RoomNumber = 101 },
                new HotelBooking { Id = 2, GuestName = "Marko", RoomNumber = 102 }
            };

            return View(bookings); // Prosljeđujemo listu rezervacija u view
        }

        // Akcija za prikaz forme za dodavanje nove rezervacije
        public IActionResult Create()
        {
            return View(); // Prikazuje Create view
        }

        // Akcija za stvaranje nove rezervacije (prima podatke iz forme)
        [HttpPost]
        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            if (ModelState.IsValid)
            {
                // Ovdje bi u stvarnoj aplikaciji išla logika za spremanje u bazu podataka
                // Sada samo prikazujemo poruku i vraćamo na Index
                return RedirectToAction("Index");
            }

            // Ako model nije ispravan, vraćamo na Create formu s prikazanim podacima
            return View("Create", newBooking);
        }
    }
}
