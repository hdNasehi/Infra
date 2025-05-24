using MassTransit;
using Microsoft.Extensions.Logging;

namespace Hesabo.EventDriven.MassTransit
{
    public class MassTransitConsumerWrapper<TMessage> : IConsumer<TMessage>
        where TMessage : class
    {
        private readonly IMessageHandler<TMessage> _handler;
        private readonly ILogger<MassTransitConsumerWrapper<TMessage>> _logger;

        public MassTransitConsumerWrapper(IMessageHandler<TMessage> handler, ILogger<MassTransitConsumerWrapper<TMessage>> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<TMessage> context)
        {
            try
            {
                _logger.LogInformation("Consuming message: {MessageType}", typeof(TMessage).Name);
                await _handler.HandleAsync(context.Message, context.CancellationToken);
                _logger.LogInformation("Message handled: {MessageType}", typeof(TMessage).Name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling message: {MessageType}", typeof(TMessage).Name);
                throw;
            }
        }
    }
}