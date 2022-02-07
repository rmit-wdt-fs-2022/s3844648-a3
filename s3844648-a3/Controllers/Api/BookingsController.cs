using Microsoft.AspNetCore.Mvc;
using s3844648_a3.Data;
using s3844648_a3.Models;

namespace s3844648_a3.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private readonly MyContext _context;

    public BookingsController(MyContext context)
    {
        _context = context;
    }

    // GET: api/bookings
    // Gets all bookings
    [HttpGet]
    public IEnumerable<Booking> Get()
    {
        return _context.Bookings.ToList();
    }
}