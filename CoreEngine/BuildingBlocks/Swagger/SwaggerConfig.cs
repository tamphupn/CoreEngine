namespace CoreEngine.BuildingBlocks.Swagger
{
    /// <summary>
    /// Defined config for swagger load from appsetting
    /// </summary>
    public class SwaggerConfig
    {
        public bool Enable { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string VersionDefault { get; set; }
    }
}