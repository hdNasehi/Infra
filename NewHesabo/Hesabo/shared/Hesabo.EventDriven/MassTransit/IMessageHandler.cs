namespace Hesabo.EventDriven.MassTransit;

public interface IMessageHandler<TMessage>
{
    Task HandleAsync(TMessage message, CancellationToken cancellationToken);
}