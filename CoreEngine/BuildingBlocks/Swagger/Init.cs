using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace CoreEngine.BuildingBlocks.Swagger
{
    /// <summary>
    /// Implement swagger config
    /// </summary>
    public static class Init
    {
        /// <summary>
        /// Init swagger
        /// </summary>
        /// <param name="services"></param>
        public static void InitSwaggerUI(this IServiceCollection services, IConfiguration configuration)
        {
            SwaggerConfig config = new SwaggerConfig();
            configuration.Bind("SwaggerConfig", config);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(config.VersionDefault, new OpenApiInfo
                {
                    Version = config.VersionDefault,
                    Title = config.Title,
                    Description = config.Description,
                });
            });
        }

        /// <summary>
        /// Init swagger in pipeline
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Document");
            });
        }
    }
}