using APP.Data.Context;
using APP.Data.Implementations;
using APP.Data.Repository;
using APP.Domain.Interfaces;
using APP.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APP.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPP;Uid=root;Pwd=")
            );
        }
    }
}
