using Microsoft.AspNetCore.Mvc;
using School.Students.Application;
using School.Students.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentCreate _studentCreate;
        private readonly StudentFinder _studentFinder;
        public StudentController(StudentCreate studentCreate, StudentFinder studentFinder)
        {
            _studentCreate = studentCreate;
            _studentFinder = studentFinder;
        }

        public IActionResult Index()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> SaveStudent([FromForm] Student student)
        {
            await _studentCreate.Create(student);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchStudent(int id)
        {
            var response = await _studentFinder.Find(id);

            return Ok(response);
        }

    }
}
