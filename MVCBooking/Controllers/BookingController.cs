using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> bookings = new List<HotelBooking>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(bookings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBooking(HotelBooking model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            model.Id = nextId++;
            bookings.Add(model);

            return RedirectToAction("Index");
        }
    }
}
