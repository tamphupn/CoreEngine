using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEngine.Domain.SeedWork
{
    public partial interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : Entity;

        Task<int> SaveChanges(CancellationToken cancellationToken = default(CancellationToken));

        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}