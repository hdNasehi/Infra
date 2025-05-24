using Hesabo.Foundation.Queries;

namespace Hesabo.Foundation.Dispatching;

public interface IQueryDispatcher
{
    Task<TResponse> QueryAsync<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default);
}