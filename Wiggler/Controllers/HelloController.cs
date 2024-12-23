using Microsoft.AspNetCore.Mvc;

namespace Wiggler.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHello")]
    public string GetHello()
    {
        return "Hello, World!";
    }

    [HttpGet("Bye", Name = "GetGoodbye")]
    public string GetGoodbye()
    {
        return "Goodbye, World!";
    }
}
