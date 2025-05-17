using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Hesabo.Foundation.Querying
{
    /// <summary>
    /// Default implementation of the IQueryBuilder interface.
    /// </summary>
    public class QueryBuilder<TEntity, TProjection> : IQueryBuilder<TEntity, TProjection>
        where TEntity : class
    {
        private IQueryable<TEntity> _query;
        private Expression<Func<TEntity, TProjection>>? _selector;

        public QueryBuilder(DbContext context)
        {
            _query = context.Set<TEntity>();
        }

        public IQueryBuilder<TEntity, TProjection> Where(Expression<Func<TEntity, bool>> predicate)
        {
            _query = _query.Where(predicate);
            return this;
        }

        public IQueryBuilder<TEntity, TProjection> OrderBy<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            _query = _query.OrderBy(keySelector);
            return this;
        }

        public IQueryBuilder<TEntity, TProjection> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            _query = _query.OrderByDescending(keySelector);
            return this;
        }

        public IQueryBuilder<TEntity, TProjection> Paginate(int pageNumber, int pageSize)
        {
            _query = _query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return this;
        }

        public IQueryBuilder<TEntity, TProjection> Select(Expression<Func<TEntity, TProjection>> selector)
        {
            _selector = selector;
            return this;
        }

        public async Task<List<TProjection>> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            if (_selector == null)
                throw new InvalidOperationException("Projection selector must be provided using Select().");

            return await _query.Select(_selector).ToListAsync(cancellationToken);
        }

        public async Task<TProjection?> GetFirstAsync(CancellationToken cancellationToken = default)
        {
            if (_selector == null)
                throw new InvalidOperationException("Projection selector must be provided using Select().");

            return await _query.Select(_selector).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<TProjection> GetSingleAsync(CancellationToken cancellationToken = default)
        {
            if (_selector == null)
                throw new InvalidOperationException("Projection selector must be provided using Select().");

            return await _query.Select(_selector).SingleAsync(cancellationToken);
        }
    }
} 
