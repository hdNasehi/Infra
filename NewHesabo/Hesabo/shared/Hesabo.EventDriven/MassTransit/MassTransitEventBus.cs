using Hesabo.EventDriven.Abstractions;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Hesabo.EventDriven.MassTransit
{
    public class MassTransitEventBus : IEventBus
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ILogger<MassTransitEventBus> _logger;

        public MassTransitEventBus(IPublishEndpoint publishEndpoint, ILogger<MassTransitEventBus> logger)
        {
            _publishEndpoint = publishEndpoint;
            _logger = logger;
        }

        public async Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
            where TEvent : class
        {
            try
            {
                _logger.LogInformation("Publishing event: {EventType}", typeof(TEvent).Name);
                await _publishEndpoint.Publish(@event, cancellationToken);
                _logger.LogInformation("Event published: {EventType}", typeof(TEvent).Name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error publishing event: {EventType}", typeof(TEvent).Name);
                throw;
            }
        }
    }
}
