using Microsoft.AspNetCore.Mvc;
using s3844648_a3.Data;
using s3844648_a3.Models;

namespace s3844648_a3.Controllers;

public class BookingController : Controller
{
    private readonly MyContext _context;

    public BookingController(MyContext context) => _context = context;

    public IActionResult Index() => View(new BookingRoomModel { Rooms = _context.Rooms.ToList(), Staff = _context.Staff.ToList() });

    [HttpPost]
    public async Task<IActionResult> Index(BookingRoomModel booking)
    {
        //validation
        ModelState.Remove("Rooms");
        ModelState.Remove("Staff");
        if (_context.Bookings.Any(x => x.RoomID == booking.RoomID && x.BookingDate == booking.BookingDate))
            ModelState.AddModelError(nameof(Booking.BookingDate), "Selected Room has already been Booked for the Selected Date.");
        if (_context.Bookings.Any(x => x.StaffID == booking.StaffID && x.BookingDate == booking.BookingDate))
            ModelState.AddModelError(nameof(Booking.BookingDate), "Selected Staff member is unavailable for the Selected Date.");
        if (booking.BookingDate < DateTime.Today)
            ModelState.AddModelError(nameof(Booking.BookingDate), "Booking Date must be in the future.");
        if (!ModelState.IsValid)
            return View(new BookingRoomModel { Rooms = _context.Rooms.ToList(), Staff = _context.Staff.ToList() });

        //insert Booking
        _context.Bookings.Add(new Booking
        {
            RoomID = booking.RoomID,
            StaffID = booking.StaffID,
            BookingDate = booking.BookingDate,
        });
        await _context.SaveChangesAsync();

        return RedirectToAction("Index", "DisplayBookings");
    }
}