using System.Reflection;
using CrowdSup.Domain.DomainServices.Token;
using CrowdSup.Domain.Interfaces.DomainServices.Token;
using Microsoft.Extensions.DependencyInjection;

namespace CrowdSup.Infra.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, Assembly apiAssembly)
        {
            // Domain Services
            services.AddTransient<ITokenService, TokenService>();
        }
    }
}