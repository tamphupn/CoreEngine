using Microsoft.Extensions.DependencyInjection;

namespace CoreEngine.BuildingBlocks.HeaderIdentity
{
    public static class RegisterIdentity
    {
        /// <summary>
        /// Register Identity Service
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServiceHeader(this IServiceCollection services)
        {
            services.AddTransient<IIdentityService, IdentityService>();

            return services;
        }
    }
}