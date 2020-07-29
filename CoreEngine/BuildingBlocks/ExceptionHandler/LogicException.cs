using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEngine.BuildingBlocks.ExceptionHandler
{
    class LogicException:Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public UserException(string message) : base(message)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public UserException(ErrorStatusReturn exception) : base(exception.ToString())
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="tag"></param>
        public UserException(string message, object tag) : base(message)
        {
            Tag = tag;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public UserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="tag"></param>
        public UserException(string message, Exception innerException, object tag)
            : base(message, innerException)
        {
            Tag = tag;
        }
    }
}
