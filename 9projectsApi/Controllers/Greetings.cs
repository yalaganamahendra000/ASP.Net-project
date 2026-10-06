using Microsoft.AspNetCore.Mvc;
namespace greeting.api;
[ApiController]
[Route("[controller]")]

public class Greetings : ControllerBase
{
    [HttpPost]
    public string post(string name)
    {
        return $"hello {name}";
    }
}