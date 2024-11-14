using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
	public class BookingController : Controller
	{
		private static List<HotelBooking> booking = new List<HotelBooking>();
		public IActionResult Index()
		{
			return View(booking);
		}
		public IActionResult Create()
		{
			HotelBooking booking = new HotelBooking();
			return View(booking);
		}
		public IActionResult CreateBooking(HotelBooking hotelViewModel)
		{
			hotelViewModel.Id = booking.Count() + 1;
			booking.Add(hotelViewModel);
			return RedirectToAction("Index");
		}
	}
}