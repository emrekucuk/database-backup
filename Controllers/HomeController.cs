using Microsoft.AspNetCore.Mvc;

namespace database_backup.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Home controller is working");
    }
}