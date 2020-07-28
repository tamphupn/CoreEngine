using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEngine.Domain.SeedWork
{
    public partial interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}