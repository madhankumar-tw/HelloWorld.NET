using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    // GET
    [HttpGet]
    public string Get()
    {
        return "Hello World!";
    }
}