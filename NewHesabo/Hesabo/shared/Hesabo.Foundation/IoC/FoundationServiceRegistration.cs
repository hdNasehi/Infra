using System.Reflection;
using Hesabo.Foundation.Dispatching;
using Microsoft.Extensions.DependencyInjection;

namespace Hesabo.Foundation.IoC;

public static class FoundationServiceRegistration
{
    public static IServiceCollection AddFoundation(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        services.AddScoped<ICommandDispatcher, CommandDispatcher>();

        return services;
    }
}