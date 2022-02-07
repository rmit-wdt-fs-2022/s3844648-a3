using Microsoft.AspNetCore.Mvc;
using s3844648_a3.Data;
using s3844648_a3.Models;

namespace s3844648_a3.Controllers;

public class StaffController : Controller
{
    private readonly MyContext _context;

    public StaffController(MyContext context) => _context = context;

    public IActionResult Index() => View(_context.Staff.ToList());

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Staff staff)
    {
        //validation
        if (_context.Staff.Any(x => x.StaffID == staff.StaffID))
            ModelState.AddModelError(nameof(staff.StaffID), "Staff with this ID already exists");
        if (!ModelState.IsValid)
            return View();

        //insert Staff
        _context.Staff.Add(new Staff
        {
            StaffID = staff.StaffID,
            FirstName = staff.FirstName,
            LastName = staff.LastName,
            Email = staff.Email,
            MobilePhone = staff.MobilePhone
        });
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}