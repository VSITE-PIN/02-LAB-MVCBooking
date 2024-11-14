using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{

	public class BookingController : Controller
	{

		private static List<HotelBooking> bookings = new List<HotelBooking>();
		public IActionResult Index()
		{
			/** HotelBooking booking = new HotelBooking();
			 booking.Id = 1;
			 booking.RoomNumber = 1;
			 booking.GuestName = "Sylvia Plath";**/
			return View(bookings);
		}

		public IActionResult Create()
		{
			HotelBooking hotelBooking = new HotelBooking();
			return View(hotelBooking);
		}

		public IActionResult CreateBooking(HotelBooking hotelViewModel)
		{
			bookings.Add(hotelViewModel);
			return RedirectToAction("Index");
		}

	}
}

