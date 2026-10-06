using Microsoft.AspNetCore.Mvc;

namespace Languages.Api;
[ApiController]
[Route("[controller]")]

public class LanguagesController : ControllerBase
{
    [HttpGet]
    public string[] get(){
        return ["python","java","c#"];
        
    }
}
