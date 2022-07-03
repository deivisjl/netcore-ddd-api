using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.CoursesStudent.Domain
{
    public interface ICourseStudentRepository
    {
        Task Save(CourseStudent record);
        Task<IEnumerable<CourseStudentViewModel>> SelectAll();
    }
}
