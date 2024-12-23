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
    public string GetHello(string? name)
    {
        if (name != null)
        {
            return $"Hello, {name}!";
        }
        return "Hello, World!";
    }

    [HttpGet("Bye", Name = "GetGoodbye")]
    public string GetGoodbye()
    {
        return "Goodbye, World!";
    }

    [HttpPost(Name = "PostHello")]
    public string PostHello([FromBody] Hello name)
    {
        return $"Hello, {name.Name}!";
    }

    [HttpPost("Bye", Name = "PostGoodbye")]
    public string PostGoodbye([FromBody] string name)
    {
        return $"Goodbye, {name}!";
    }
}
