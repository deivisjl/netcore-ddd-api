using School.Courses.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Courses.Application
{
    public class CourseFinder
    {
        private readonly ICourseRepository _repository;

        public CourseFinder(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<Course> Find(int id)
        {
            return await _repository.Search(id);
        }
    }
}
