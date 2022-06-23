using Microsoft.EntityFrameworkCore;
using School.Students.Domain;

namespace School.Shared
{
    public class SchoolContext : DbContext
    { 
        public DbSet<Student> Student { get; set; }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
    }
}
