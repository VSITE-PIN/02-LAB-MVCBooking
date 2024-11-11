using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View(bookings);
        }
        private static List<HotelBooking> bookings = new List<HotelBooking>()
        {
            new HotelBooking {Id = 1, GuestName = "Kevin", RoomNumber = 47 },
            new HotelBooking {Id = 2, GuestName = "Mark", RoomNumber = 23 },
            new HotelBooking {Id = 3, GuestName = "John", RoomNumber = 11 }
        };
        public IActionResult Create()
        {
            HotelBooking hotelBooking = new HotelBooking();
            return View(hotelBooking);
        }
        public IActionResult CreateBooking(HotelBooking newBooking)
        {
            bookings.Add(newBooking);
            return RedirectToAction("Index");
        }
    }
}
