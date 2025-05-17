using System.Diagnostics.CodeAnalysis;

namespace Hesabo.Foundation.Persistence.Interfaces;

public interface IReadOnlyDbContext
    {
        /// <summary>
        /// Gets a DbSet for the given entity type.
        /// </summary>
        /// <typeparam name="TEntity">Entity type.</typeparam>
        /// <returns>A no-tracking IQueryable of the entity.</returns>
        IQueryable<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TEntity>()
            where TEntity : class;
    }