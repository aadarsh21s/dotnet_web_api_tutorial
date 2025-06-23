using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public List<Student> GetAllStudents()
    {
        return CollegeRepository.Students;
    }
    

}