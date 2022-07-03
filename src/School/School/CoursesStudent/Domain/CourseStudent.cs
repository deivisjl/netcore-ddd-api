using School.Courses.Domain;
using School.Helper;
using School.Students.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace School.CoursesStudent.Domain
{
    public class CourseStudent : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
