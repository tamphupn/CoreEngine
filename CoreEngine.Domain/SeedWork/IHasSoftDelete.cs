namespace CoreEngine.Domain.SeedWork
{
    /// <summary>
    /// Defined soft delete interface
    /// </summary>
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}