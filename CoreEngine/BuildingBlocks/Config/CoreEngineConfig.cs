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
        public bool EnableHmacAuthentication { get; set; } = true;
    }
}