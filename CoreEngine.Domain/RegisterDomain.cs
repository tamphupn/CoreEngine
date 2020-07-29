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
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCoreEngineDomain(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient((typeof(IRepository<>)), (typeof(EfRepository<>)));

            return services;
        }
    }
}