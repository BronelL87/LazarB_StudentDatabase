using LazarB_StudentDatabase.Models;
using LazarB_StudentDatabase.Services.Students;
using Microsoft.AspNetCore.Mvc;


namespace LazarB_StudentDatabase.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class SdntDataController : Controller
    {
    private readonly ISdntServices _sdntServices;

    public SdntDataController(ISdntServices sdntServices)
    {
        _sdntServices = sdntServices;
    }

    [HttpGet]
    [Route("FetchQuest")]

    public List<Student> GetStudents()
    {
        return _sdntServices.GetStudents();
    }

    [HttpPost]
    [Route("AddStudent/{FirstN}/{LastN}/{Hobby}")]

    public List<Student> AddStudent(string FirstN, string LastN, string Hobby)
    {
        return _sdntServices.AddStudent(FirstN, LastN, Hobby);
    }

    [HttpDelete]
    [Route("DeleteStudent/{FirstN}")]

    public List<Student> DeleteStudent(string FirstN)
    {
        return _sdntServices.DeleteStudent(FirstN);
    }
    }
