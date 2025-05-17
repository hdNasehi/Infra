namespace Hesabo.Foundation.Queries;

public abstract class QueryHandler<TQuery, TResponse> : IQueryHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
    
    public abstract Task<TResponse> HandleAsync(TQuery query, CancellationToken cancellationToken);
}