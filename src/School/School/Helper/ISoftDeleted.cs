using System;
using System.Collections.Generic;
using System.Text;

namespace School.Helper
{
    public interface ISoftDeleted
    {
        bool IsDeleted { get; set; }
    }
}
