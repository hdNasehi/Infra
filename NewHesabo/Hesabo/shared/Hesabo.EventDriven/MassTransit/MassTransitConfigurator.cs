using System.Reflection;
using Hesabo.EventDriven.Abstractions;
using Hesabo.EventDriven.RabbitMq;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hesabo.EventDriven.MassTransit
{
    public static class MassTransitConfigurator
    {
        private static string _sectionName = "RabbitMQ";
        public static void AddMassTransitWithRabbitMQ(this IHostApplicationBuilder builder,
             Assembly targetAssembly, string messagePrefix)
        {
            RabbitMqOptions? rabbitMqOptions = builder.Configuration.GetSection(_sectionName).Get<RabbitMqOptions>() ??
                                               throw new ArgumentNullException(
                                                   "RabbitMQ configuration is missing in appsettings.json");


            builder.Services.AddMassTransit(x =>
            {
                x.AddConsumers(targetAssembly);

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(rabbitMqOptions.Host, builder.Environment.EnvironmentName, h =>
                    {
                        h.Username(rabbitMqOptions.Username);
                        h.Password(rabbitMqOptions.Password);
                    });
                    cfg.ConfigureEndpoints(context);
                });
                x.SetEndpointNameFormatter(
                    new KebabCaseEndpointNameFormatter(prefix: $"{messagePrefix}-", includeNamespace: false));
            });

            builder.Services.AddScoped<IEventBus, MassTransitEventBus>();
        }
    }
}