using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BankManagment_DependencyInjectionExtensions
{

    public static class IServiceCollectionExtensions
    {
        public static void RegisterServicesAndRepositories(this IServiceCollection services, Assembly assembly)
        {
            services.Scan(selector => selector
                .FromAssemblies(assembly)
                .AddClasses(classes => classes
                    .InNamespaces("BankManagment_Services", "BankManagment_Infrastructure"))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }

    }

}
