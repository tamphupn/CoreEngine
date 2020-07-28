using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

namespace CoreEngine.BuildingBlocks.CommonPackage
{
    public static class GzipCompress
    {
        /// <summary>
        /// Register gzip compress
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddGzipCompress(this IServiceCollection services)
        {
            services.AddResponseCompression(option =>
            {
                option.Providers.Add<GzipCompressionProvider>();
                option.EnableForHttps = true;
            });

            services.Configure<GzipCompressionProviderOptions>(option =>
            {
                option.Level = System.IO.Compression.CompressionLevel.Fastest;
            });

            return services;
        }

        /// <summary>
        /// Use Gzip compress
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseGzipCompress(this IApplicationBuilder app)
        {
            app.UseResponseCompression();

            return app;
        }
    }
}