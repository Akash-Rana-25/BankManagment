using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using BankManagment_DependencyInjectionExtensions;
namespace TestProject1
{
    public class IServiceCollectionExtensionsTests
    {
        [Fact]
        public void RegisterServicesAndRepositories_RegistersServicesAndRepositoriesWithScopedLifetime()
        {
            // Arrange
            var services = new ServiceCollection();
            var assembly = typeof(IServiceCollectionExtensionsTests).GetTypeInfo().Assembly;

            // Add a breakpoint here to ensure that the assembly and services are correctly set up
            System.Diagnostics.Debugger.Break();

            // Act
            try
            {
                services.RegisterServicesAndRepositories(assembly);  // Access the extension method here

                // Assert
                var serviceDescriptors = services.ToList();
                foreach (var descriptor in serviceDescriptors)
                {
                    if (descriptor.ImplementationType != null)
                    {
                        // Check if the service is registered with ScopedLifetime
                        Assert.Equal(ServiceLifetime.Scoped, descriptor.Lifetime);
                        // Add more specific checks if needed
                    }
                }

                // Debug message indicating success
                System.Diagnostics.Debug.WriteLine("Success: Services and repositories registered.");
            }
            catch (Exception ex)
            {
                // Debug message indicating failure and providing exception details
                System.Diagnostics.Debug.WriteLine($"Failure: {ex.Message}");
                throw; // Rethrow the exception to fail the test
            }
        }
    }

}

