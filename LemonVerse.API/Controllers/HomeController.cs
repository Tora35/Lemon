using Microsoft.AspNetCore.Mvc;

namespace LemonVerse.API.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("🍋 Welcome to LemonVerse API!"); //tora e cool 
}
