using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Teacher")]
public class TeacherController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Teacher> GetAllTeacher()
    {
        return new List<Teacher>
        {
            new Teacher{ Address= "test", Name= "jjj" },
            new Teacher { }
        };

    }
}