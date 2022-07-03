using School.CoursesStudent.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.CoursesStudent.Application
{
    public class CourseStudentCreate
    {
        private readonly ICourseStudentRepository _repository;

        public CourseStudentCreate(ICourseStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task Save(CourseStudent record)
        {
            await _repository.Save(record);
        }

        public async Task<IEnumerable<CourseStudentViewModel>> GetAll()
        {
            return await _repository.SelectAll();
        }
    }
}
