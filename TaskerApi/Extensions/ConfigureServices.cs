using BLL.Interfaces;
using BLL.Mapping;
using BLL.Services;
using DAL.Repository;

namespace TaskerApi.Extensions;

public static class ConfigureServices
{
    public static void AddConfigureServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();
        services.AddScoped<IAssignmentService, AssignmentService>();
    }
}
