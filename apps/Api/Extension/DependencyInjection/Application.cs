using Microsoft.Extensions.DependencyInjection;
using School.Students.Application;

namespace Api.Extension.DependencyInjection
{
    public static class Application
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<StudentCreate, StudentCreate>();
            services.AddScoped<StudentFinder, StudentFinder>();

            return services;
        }
    }
}
