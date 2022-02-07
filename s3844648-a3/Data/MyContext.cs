using Microsoft.EntityFrameworkCore;
using s3844648_a3.Models;

namespace s3844648_a3.Data;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options) {}

    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Staff> Staff { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Booking>().HasKey(x => new { x.RoomID, x.BookingDate });
    }
}

