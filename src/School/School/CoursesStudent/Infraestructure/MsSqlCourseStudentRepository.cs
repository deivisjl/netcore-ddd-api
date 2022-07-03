using School.CoursesStudent.Domain;
using School.Shared;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace School.CoursesStudent.Infraestructure
{
    public class MsSqlCourseStudentRepository : ICourseStudentRepository
    {
        private readonly SchoolContext _context;

        public MsSqlCourseStudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task Save(CourseStudent record)
        {
            await _context.CourseStudent.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseStudentViewModel>> SelectAll()
        {
            var query = (
                from s in _context.Student
                join cs in _context.CourseStudent on s.Id equals cs.StudentId
                join c in _context.Course on cs.CourseId equals c.Id 
                select new CourseStudentViewModel
                    {
                        Id = cs.Id,
                        CourseName = c.Name,
                        StudentName = s.Name
                    }
                ).AsQueryable();

            return await query.ToListAsync();
        }
    }
}
