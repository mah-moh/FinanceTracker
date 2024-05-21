using Microsoft.Extensions.DependencyInjection;

namespace FinanceTracker.Handlers
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddUserHandler (this IServiceCollection services)
        {
            services.AddScoped<IAddUserHandler, AddUserHandler>();
            return services;
        }
    }
}