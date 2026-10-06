using Microsoft.AspNetCore.Mvc;
namespace addtwonumbers.Api;
[ApiController]
[Route("[controller]")]
public class Sum : ControllerBase
{
    [HttpPost]
    public int post(int number1, int number2){
        return number1+number2;
        
    }
}