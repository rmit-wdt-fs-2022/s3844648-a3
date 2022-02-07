using System.ComponentModel.DataAnnotations;

namespace s3844648_a3.Models;
public class Booking
{
    [Display(Name = "Room ID")]
    public string RoomID { get; set; }
    public Room Room { get; set; }

    [Display(Name = "Booking Date")]
    [DataType(DataType.Date)]
    public DateTime BookingDate { get; set; }

    [Display(Name = "Staff ID")]
    public string StaffID { get; set; }
    public Staff Staff { get; set; }
}