using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistiration
    {
        //Ioc container'a data yollamak için bu sınıfı kullanıyoruz
        public static void AddPersistanceServices(this IServiceCollection services) 
        {
            services.AddDbContext<ETicaretAPIDbContext>(x => x.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            //Repositories
            services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository,OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository,OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository,ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository,ProductWriteRepository>();
            //Repositories
        }
    }
}
