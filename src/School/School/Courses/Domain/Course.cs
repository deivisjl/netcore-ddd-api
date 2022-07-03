using School.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace School.Courses.Domain
{
    public class Course : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
