using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
	public class BookingController : Controller
	{
		
		private static List<HotelBooking> bookings = new List<HotelBooking>();

		
		public IActionResult Index()
		{
			return View(bookings);
		}

		
		public IActionResult Create()
		{
			return View();
		}

		
		[HttpPost]
		public IActionResult CreateBooking(HotelBooking booking)
		{
			
			booking.Id = bookings.Count + 1;
			bookings.Add(booking);
			return RedirectToAction("Index");
		}
	}
}