using System.ComponentModel.DataAnnotations.Schema;

namespace School.Students.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "Text")]
        public string Address { get; set; }
    }
}
