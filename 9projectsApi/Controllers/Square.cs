using Microsoft.AspNetCore.Mvc;
namespace square.Api;
[ApiController]
[Route("[controller]")]

public class Sqaure : ControllerBase
{
    [HttpPost]
    public int post(int number)
    {
        return number*number;
    }
}