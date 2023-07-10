using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistiration
    {
        //Ioc container'a data yollamak için bu sınıfı kullanıyoruz
        public static void AddPersistanceServices(this IServiceCollection services) 
        {
         services.AddDbContext<ETicaretAPIDbContext>(x => x.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
