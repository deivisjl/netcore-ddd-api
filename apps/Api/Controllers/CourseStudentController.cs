using Microsoft.AspNetCore.Mvc;
using School.CoursesStudent.Application;
using School.CoursesStudent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseStudentController : ControllerBase
    {
        private readonly CourseStudentCreate _courseStudentCreate;

        public CourseStudentController(CourseStudentCreate courseStudentCreate)
        {
            _courseStudentCreate = courseStudentCreate;
        }


        // GET: api/<CourseStudentController>
        [HttpGet]
        public async Task<IEnumerable<CourseStudentViewModel>> Get()
        {
            return await _courseStudentCreate.GetAll();
        }

        // GET api/<CourseStudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CourseStudentController>
        [HttpPost]
        public async Task<IActionResult> SaveCourseStudent([FromForm] CourseStudent courseStudent)
        {
            await _courseStudentCreate.Save(courseStudent);

            return Ok();
        }

        // PUT api/<CourseStudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CourseStudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
