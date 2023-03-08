using Loja.Infrastructure.Contexts;
using Microsoft.AspNetCore.Identity;

namespace Loja;

public static class DependencyInjection
{
    public static IServiceCollection AddUI(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();
        services.AddControllersWithViews();

        return services;
    }

    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services.AddDefaultIdentity<IdentityUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
        })
            .AddEntityFrameworkStores<ApplicationDbContext>();

        return services;
    }
}
