using Framework.MessageBus.Abstraction;
using Hesabo.EventDriven.Models;

namespace Hesabo.EventDriven.Abstractions;

public interface IIntegrationEventHandler<in TEvent>
    where TEvent : IntegrationBaseEvent
{
    Task HandleAsync(TEvent @event, CancellationToken cancellationToken);
}