using School.Students.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Application
{
    public class StudentFinder
    {
        private readonly IStudentRepository _repository;

        public StudentFinder(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Student> Find(int id)
        {
            return await _repository.Search(id);
        }
    }
}
