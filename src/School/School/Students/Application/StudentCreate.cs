using School.Students.Domain;
using System.Threading.Tasks;

namespace School.Students.Application
{
    public class StudentCreate
    {
        private readonly IStudentRepository _repository;

        public StudentCreate(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task Create(Student student)
        {
            await _repository.Save(student);
        }
    }
}
