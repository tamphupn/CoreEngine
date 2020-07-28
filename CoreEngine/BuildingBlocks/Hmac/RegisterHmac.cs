using Cloud_Net_Sdk_Hmac_Lib.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace CoreEngine.BuildingBlocks.Hmac
{
    public static class RegisterHmac
    {
        /// <summary>
        /// Register Hmac authentication
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddHmacAuthen(this IServiceCollection services)
        {
            services.AddAuthentication(HMACAuthOptions.Scheme).AddScheme<HMACAuthOptions, CustomAuthHandler>(HMACAuthOptions.Scheme, null);

            return services;
        }
    }
}