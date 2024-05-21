using Microsoft.Extensions.DependencyInjection;

namespace FinanceTracker.Repoisitories
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUserRepository (this IServiceCollection services)
        {
            services.AddScoped<IAddUserRepository, AddUserRepository>();
            return services;
        }
    }
}