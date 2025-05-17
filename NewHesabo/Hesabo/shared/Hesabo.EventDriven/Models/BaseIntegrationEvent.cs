using Hesabo.EventDriven.Abstractions;

namespace Hesabo.EventDriven.Models;

public abstract class BaseIntegrationEvent : IIntegrationEvent
{
    public Guid CorrelationId { get; set; } = Guid.NewGuid();
    public DateTime OccurredOn { get; set; } = DateTime.UtcNow;
}