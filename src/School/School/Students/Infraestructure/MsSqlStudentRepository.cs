using Microsoft.EntityFrameworkCore;
using School.Shared;
using School.Students.Domain;
using System;
using System.Threading.Tasks;

namespace School.Students.Infraestructure
{
    public class MsSqlStudentRepository : IStudentRepository
    {
        private readonly SchoolContext _context;

        public MsSqlStudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task Save(Student student)
        {
            await _context.Student.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> Search(int id)
        {
            var student = await _context.Student.FirstOrDefaultAsync(c => c.Id.Equals(id));

            return student;
        }
    }
}
