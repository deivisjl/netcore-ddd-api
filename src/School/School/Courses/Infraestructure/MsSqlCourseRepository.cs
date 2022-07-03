using Microsoft.EntityFrameworkCore;
using School.Courses.Domain;
using School.Shared;
using System;
using System.Threading.Tasks;

namespace School.Courses.Infraestructure
{
    public class MsSqlCourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;

        public MsSqlCourseRepository(SchoolContext schoolContext)
        {
            _context = schoolContext;
        }

        public async Task Save(Course course)
        {
            await _context.Course.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task<Course> Search(int id)
        {
            var course = await _context.Course.FirstOrDefaultAsync(c => c.Id.Equals(id));

            return course;
        }
    }
}
