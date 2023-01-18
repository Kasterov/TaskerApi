using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace TaskerApi.Extensions;

public static class DatabaseContextExstension
{
    public static void AddDbContextCustom(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContext<TaskerDbContext>(opt => opt
            .UseSqlServer(builder.Configuration
            .GetConnectionString("DefualtConnection"), b => b.MigrationsAssembly("DAL")));
    }
}
