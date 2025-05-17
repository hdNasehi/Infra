using System.Linq.Expressions;

namespace Hesabo.Foundation.Querying;

/// <summary>
/// Interface for building and executing queries with filtering, sorting, and pagination.
/// </summary>
public interface IQueryBuilder<TEntity, TProjection>
    where TEntity : class
{
    IQueryBuilder<TEntity, TProjection> Where(Expression<Func<TEntity, bool>> predicate);
    IQueryBuilder<TEntity, TProjection> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector);
    IQueryBuilder<TEntity, TProjection> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector);
    IQueryBuilder<TEntity, TProjection> Paginate(int pageNumber, int pageSize);
    IQueryBuilder<TEntity, TProjection> Select(Expression<Func<TEntity, TProjection>> selector);

    Task<List<TProjection>> ExecuteAsync(CancellationToken cancellationToken = default);
    Task<TProjection?> GetFirstAsync(CancellationToken cancellationToken = default);
    Task<TProjection> GetSingleAsync(CancellationToken cancellationToken = default);
}