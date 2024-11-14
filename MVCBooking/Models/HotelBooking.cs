using System.ComponentModel.DataAnnotations;

namespace MVCBooking.Models
{
    public class HotelBooking
    {
        [Key]
        public int Id { get; set; }

        [Required] // Validacija da je GuestName obavezno polje
        public required string GuestName { get; set; }  // required osigurava inicijalizaciju

        [Required] // Validacija da je RoomNumber obavezno polje
        public int RoomNumber { get; set; }
    }
}
