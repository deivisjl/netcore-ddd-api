using School.Helper;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Students.Domain
{
    public class Student : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "Text")]
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
