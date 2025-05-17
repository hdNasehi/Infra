﻿namespace Hesabo.Foundation.Domain.Events;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
public abstract record DomainEvent : IDomainEvent
{
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}