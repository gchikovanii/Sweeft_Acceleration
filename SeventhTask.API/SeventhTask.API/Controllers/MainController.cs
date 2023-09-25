using Microsoft.AspNetCore.Mvc;
using SeventhTask.API.SeventhTask.Application;
using SeventhTask.Domain.Entities;

namespace SeventhTask.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly IMainService _mainService;

        public MainController(IMainService mainService)
        {
            _mainService = mainService;
        }


        [HttpGet]
        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            return _mainService.GetAllTeachersByStudent(studentName);
        }
    }
}
