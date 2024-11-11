namespace MVCBooking.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

public class HotelBooking 
{
     public int Id {  get; set; }  
    public string GuestName { get; set; }
    public int RoomNumber { get; set; } 
}