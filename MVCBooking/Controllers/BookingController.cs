using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;


namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        
        public ActionResult Index()
        {
            return View(bookings);
        }

        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBooking(HotelBooking booking)
        {
            if (ModelState.IsValid)
            {
                booking.Id = bookings.Count + 1;
                bookings.Add(booking);
                return RedirectToAction("Index");
            }

            return View("Create", booking);
        }
    }
}
