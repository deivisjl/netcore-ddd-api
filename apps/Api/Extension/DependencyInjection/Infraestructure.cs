using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Courses.Domain;
using School.Courses.Infraestructure;
using School.CoursesStudent.Domain;
using School.CoursesStudent.Infraestructure;
using School.Shared;
using School.Students.Domain;
using School.Students.Infraestructure;

namespace Api.Extension.DependencyInjection
{
    public static class Infraestructure
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SchoolContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IStudentRepository, MsSqlStudentRepository>();
            services.AddScoped<ICourseRepository, MsSqlCourseRepository>();
            services.AddScoped<ICourseStudentRepository, MsSqlCourseStudentRepository>();

            return services;
        }
    }
}
