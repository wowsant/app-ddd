using APP.Domain.Interfaces.Services.User;
using APP.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace APP.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}