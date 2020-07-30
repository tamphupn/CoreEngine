using CoreEngine.Domain.SeedWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreEngine.Domain
{
    public static class RegisterDomain
    {
        /// <summary>
        /// Register core engine for domain data accesss
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCoreEngineDomain(this IServiceCollection services)
        {
            services.AddTransient((typeof(IRepository<>)), (typeof(EfRepository<>)));

            return services;
        }
    }
}