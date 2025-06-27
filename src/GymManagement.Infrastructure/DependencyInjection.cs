using GymManagement.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISubscriptionsWriteService, SubscriptionsService>();

            return services;
        }
    }
}
