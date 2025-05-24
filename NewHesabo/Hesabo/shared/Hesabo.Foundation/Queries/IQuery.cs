using MediatR;

namespace Hesabo.Foundation.Queries;

public interface IQuery<TResponse> : IRequest<TResponse>
{
    Guid CorrelationId { get; }
}

public class Query<TResponse> : IQuery<TResponse>
{
    public Guid CorrelationId { get; protected set; } = Guid.NewGuid();
}