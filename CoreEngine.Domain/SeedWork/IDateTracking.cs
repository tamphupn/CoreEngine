using System;

namespace CoreEngine.Domain.SeedWork
{
    /// <summary>
    /// Defined date tracking property
    /// </summary>
    public interface IDateTracking
    {
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}