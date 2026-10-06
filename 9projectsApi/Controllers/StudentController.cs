using Microsoft.AspNetCore.Mvc;

namespace Studentrecord.Api;
[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    [HttpGet]
    public Student get()
    {
         Student student = new Student
        {
            Id = 101,
            Name = "satyam",
            Course = "B.Tech",
            Age = 25
        };
        return student;
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Age { get; set; }
}