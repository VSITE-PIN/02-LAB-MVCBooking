using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
    public class HomeController : Controller
    {
        // Stati?ka lista koja ?e pohranjivati rezervacije
        private static List<HotelBooking> bookings = new List<HotelBooking>
        {
            new HotelBooking { Id = 1, GuestName = "Ana", RoomNumber = 101 },
            new HotelBooking { Id = 2, GuestName = "Marko", RoomNumber = 102 }
        };

        // Akcija za prikaz svih rezervacija
        public IActionResult Index()
        {
            return View(bookings); // Proslje?ujemo listu rezervacija u view
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
                // Dodajemo novu rezervaciju u stati?ku listu
                newBooking.Id = bookings.Count + 1; // Generiramo novi Id
                bookings.Add(newBooking);

                // Preusmjeravamo na Index stranicu s ažuriranom listom
                return RedirectToAction("Index");
            }

            // Ako model nije ispravan, vra?amo na formu
            return View("Create", newBooking);
        }
    }
}
