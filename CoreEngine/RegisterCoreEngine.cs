using CoreEngine.BuildingBlocks.CommonPackage;
using CoreEngine.BuildingBlocks.Config;
using CoreEngine.BuildingBlocks.HeaderIdentity;
using CoreEngine.BuildingBlocks.Hmac;
using CoreEngine.BuildingBlocks.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreEngine
{
    /// <summary>
    /// Register core engine component
    /// </summary>
    public static class RegisterCoreEngine
    {
        private static CoreEngineRegisterConfig config = new CoreEngineRegisterConfig();

        /// <summary>
        /// Register core engine service
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IServiceCollection AddCoreEngine(this IServiceCollection services, IConfiguration configuration)
        {
            config = GetCoreEngineConfig(configuration);

            if (config.EnableGzip) services.AddGzipCompress();
            if (config.EnableIdentityServiceHeader) services.AddIdentityServiceHeader();
            if (config.EnableSwaggerUI) services.InitSwaggerUI(configuration);
            if (config.EnableHmacAuthentication) services.AddHmacAuthen();

            return services;
        }

        /// <summary>
        /// Load data core engine
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        private static CoreEngineRegisterConfig GetCoreEngineConfig(IConfiguration configuration)
        {
            CoreEngineRegisterConfig config = new CoreEngineRegisterConfig();
            configuration.Bind("CoreEngine", config);

            return config;
        }

        /// <summary>
        /// Using core engine
        /// </summary>
        /// <param name="app"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCoreEngine(this IApplicationBuilder app)
        {
            if (config.EnableGzip) app.UseGzipCompress();
            if (config.EnableSwaggerUI) app.UseSwaggerUI();

            return app;
        }
    }
}