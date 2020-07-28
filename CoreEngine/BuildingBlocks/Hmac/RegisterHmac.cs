using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEngine.BuildingBlocks.Hmac
{
    public static class RegisterHmac
    {
        /// <summary>
        /// Register Hmac authen
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServiceHeader(this IServiceCollection services)
        {
            // TODO add hmac lib

            return services;
        }
    }
}
