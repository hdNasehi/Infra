namespace Hesabo.Domain.Abstractions.Domain.Entities;

public abstract class BaseEntity<TId>
{
    public TId Id { get; protected set; }
    
    public override bool Equals(object? obj) =>
        obj is BaseEntity<TId> other && EqualityComparer<TId>.Default.Equals(Id, other.Id);

    public override int GetHashCode() => Id?.GetHashCode() ?? 0;
}