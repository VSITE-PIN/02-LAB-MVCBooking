using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View(bookings);
		}

		
		private static List<HotelBooking> bookings = new List<HotelBooking>();

		public IActionResult Create()
		{
			HotelBooking booking = new HotelBooking();
			return View();
		}

		public IActionResult CreateBooking(HotelBooking booking)
		{
			booking.Id = bookings.Count + 1;
			bookings.Add(booking);
			return RedirectToAction("Index");
		}


	}
}
