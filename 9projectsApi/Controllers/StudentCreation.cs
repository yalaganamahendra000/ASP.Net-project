using Microsoft.AspNetCore.Mvc;

namespace student.Api;

[ApiController]
[Route("[controller]")]
public class StudentCreation : ControllerBase
{
    [HttpPost]
    public object Post(StudentCreationRequest student)
    {
        return new
        {
            message = "Student created successfully",
            name = student.Name,
            age = student.Age,
            course = student.Course
        };
    }
}

public record StudentCreationRequest(
    string Name,
    int Age,
    string Course
);