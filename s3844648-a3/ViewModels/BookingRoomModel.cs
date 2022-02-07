using System.ComponentModel.DataAnnotations;

namespace s3844648_a3.Models;
public class BookingRoomModel
{
    [Display(Name = "Room ID")]
    public string RoomID { get; set; }

    [Display(Name = "Booking Date")]
    [DataType(DataType.Date)]
    public DateTime BookingDate { get; set; }

    [Display(Name = "Staff ID")]
    public string StaffID { get; set; }

    public List<Room> Rooms { get; set; }

    public List<Staff> Staff { get; set; }
}