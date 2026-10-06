using Microsoft.AspNetCore.Mvc;

namespace employeesearch.Api;
[ApiController]
[Route("[controller]")]

public class EmployeeSearch : ControllerBase
{
    [HttpPost]
    public object post(int id)
    {
        if (id == 101)
        {
            return new
            {
                Id=101,
                Name="Rahul",
                Department="IT"
            };
        }
        return "Employee Not found";
    }
}
