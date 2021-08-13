using APP.Data.Context;
using APP.Data.Repository;
using APP.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APP.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext> (
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPP;Uid=root;Pwd=")
            );
        }
    }
}