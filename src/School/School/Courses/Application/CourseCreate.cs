using School.Courses.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Courses.Application
{
    public class CourseCreate
    {
        private readonly ICourseRepository _repository;

        public CourseCreate(ICourseRepository repository)
        {
            _repository = repository;
        }
        public async Task SaveCourse(Course course)
        {
            await _repository.Save(course);
        }

    }
}
