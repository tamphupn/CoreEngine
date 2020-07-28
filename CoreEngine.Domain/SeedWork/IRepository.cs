namespace CoreEngine.Domain.SeedWork
{
    public partial interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}