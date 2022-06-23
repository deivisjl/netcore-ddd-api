using Microsoft.EntityFrameworkCore;
using School.Student.Domain;

namespace Shared
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
    }
}
