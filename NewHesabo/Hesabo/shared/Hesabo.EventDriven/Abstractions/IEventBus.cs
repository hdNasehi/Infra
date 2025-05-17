namespace Hesabo.EventDriven.Abstractions;

public interface IEventBus
{
    Task PublishAsync<TEvent>(TEvent @event) where TEvent : IIntegrationEvent;
}