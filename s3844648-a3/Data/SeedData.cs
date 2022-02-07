using s3844648_a3.Models;
using Newtonsoft.Json;

namespace s3844648_a3.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<MyContext>();

        if (context.Rooms.Any())
            return;

        // Seed Rooms
        context.Rooms.Add(new Room
        {
            RoomID = "14.10.31",
            Capacity = 100,
            HasProjector = true
        });
        context.Rooms.Add(new Room
        {
            RoomID = "14.09.15",
            Capacity = 200,
            HasProjector = false
        });

        // Seed Staff
        context.Staff.Add(new Staff
        {
            StaffID = "e12345",
            FirstName = "John",
            LastName = "Smith",
            Email = "john@hotmail.com",
            MobilePhone = "0412345678"
        });
        context.Staff.Add(new Staff
        {
            StaffID = "e54321",
            FirstName = "Steve",
            LastName = "Williams",
            Email = "steve@gmail.com",
            MobilePhone = "0487654321"
        });

        context.SaveChanges();
    }
}
