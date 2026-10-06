using Microsoft.AspNetCore.Mvc;

namespace Hello.Api;

[ApiController]
[Route("[controller]")]

public class HelloControllers : ControllerBase
{
    [HttpGet]
    public string get()
    {
        return "hello, Welcome to Asp.Net Core!";
    }
}