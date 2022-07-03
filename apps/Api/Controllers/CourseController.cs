using Microsoft.AspNetCore.Mvc;
using School.Courses.Application;
using School.Courses.Domain;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseCreate _courseCreate;
        private readonly CourseFinder _courseFinder;

        public CourseController(CourseCreate courseCreate, CourseFinder courseFinder)
        {
            _courseCreate = courseCreate;
            _courseFinder = courseFinder;
        }
        public async Task<IActionResult> SaveCourse([FromForm] Course course)
        {
            await _courseCreate.SaveCourse(course);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchCourse(int id)
        {
            var response = await _courseFinder.Find(id);

            return Ok(response);
        }
    }
}
