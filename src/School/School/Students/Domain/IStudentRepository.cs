using System.Threading.Tasks;

namespace School.Students.Domain
{
    public interface IStudentRepository
    {
        Task Save(Student student);
        Task<Student> Search(int id);
    }
}
