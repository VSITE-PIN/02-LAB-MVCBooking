namespace MVCBooking.Models
{
    public class HotelBooking
    {
        public int id { get; set; }

        public string GuestName { get; set; } = string.Empty;
        
        public int RoomNumber { get; set; }
    }
}
