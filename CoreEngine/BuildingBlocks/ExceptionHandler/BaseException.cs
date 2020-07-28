using System;

namespace CoreEngine.BuildingBlocks.ExceptionHandler
{
    /// <summary>
    /// Defined base class exception
    /// </summary>
    public partial class BaseException : Exception
    {
        public BaseException()
        { }

        public BaseException(string message)
            : base(message)
        { }

        public BaseException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}