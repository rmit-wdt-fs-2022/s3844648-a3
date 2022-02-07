using System.ComponentModel.DataAnnotations;

namespace s3844648_a3.Models;
public class Booking
{
    public string RoomID { get; set; }
    public Room Room { get; set; }

    public DateTime BookingDate { get; set; }

    public string StaffID { get; set; }
    public Staff Staff { get; set; }
}