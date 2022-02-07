using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using s3844648_a3.Models;

namespace s3844648_a3.Controllers;

public class DisplayBookingsController : Controller
{
    private readonly IHttpClientFactory _clientFactory;
    private HttpClient Client => _clientFactory.CreateClient();
    public DisplayBookingsController(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;
    
    public async Task<IActionResult> Index()
    {
        // Get Bookings
        var response = await Client.GetStringAsync("api/bookings");
        var bookings = JsonConvert.DeserializeObject<List<Booking>>(response);

        return View(bookings);
    }
}
