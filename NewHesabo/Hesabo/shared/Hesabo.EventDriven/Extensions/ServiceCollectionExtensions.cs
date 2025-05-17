using Microsoft.Extensions.DependencyInjection;

namespace Hesabo.EventDriven.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEventDrivenInfrastructure(this IServiceCollection services)
    {
        // register MassTransit and your own abstraction
        return services;
    }
}