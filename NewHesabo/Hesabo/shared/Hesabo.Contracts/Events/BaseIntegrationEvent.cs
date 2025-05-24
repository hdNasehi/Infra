// namespace Hesabo.Application.Contracts.Events;
//
// public abstract class BaseIntegrationEvent
// {
//     public Guid EventId { get; init; } = Guid.NewGuid();
//     public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
//     public string CorrelationId { get; init; }
//
//     protected BaseIntegrationEvent(string correlationId)
//     {
//         CorrelationId = correlationId;
//     }
//
//     protected BaseIntegrationEvent() {}
// }