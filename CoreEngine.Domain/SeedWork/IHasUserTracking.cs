namespace CoreEngine.Domain.SeedWork
{
    /// <summary>
    /// Defined user tracking action
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHasUserTracking<T>
    {
        T CreatedBy { get; set; }
        T UpdatedBy { get; set; }
    }
}