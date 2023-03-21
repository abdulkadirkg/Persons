using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Persons.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly Context _context;

    public PersonController(Context context)
    {
        _context = context;
    }

    [HttpPost("insert")]
    public async Task<IActionResult> Insert()
    {
        await _context.AddAsync(new Person { name = "Ali", surname = "Veli" });
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("read")]
    public async Task<IActionResult> Read()
    {
        return Ok(await _context.Persons.ToArrayAsync());
    }
}