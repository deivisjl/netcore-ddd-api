using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Courses.Domain
{
    public interface ICourseRepository
    {
        Task Save(Course course);
        Task<Course> Search(int id);
    }
}
