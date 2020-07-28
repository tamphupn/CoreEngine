using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEngine.BuildingBlocks.Config
{
    /// <summary>
    /// Defined class register common service
    /// </summary>
    public class CoreEngineRegisterConfig
    {
        public bool EnableGzip { get; set; } = true;
        public bool EnableIdentityServiceHeader { get; set; } = true;
        public bool EnableSwaggerUI { get; set; } = true;
    }

    /// <summary>
    /// Defined class using common service
    /// </summary>
    public class CoreEngineUsingConfig
    {
        public bool EnableGzip { get; set; }

        public bool EnableSwaggerUI { get; set; }
    }
}
