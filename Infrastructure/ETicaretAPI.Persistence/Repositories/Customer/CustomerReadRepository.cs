using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    //ReadRepository Customer'a ozel tum metodlar uygulanacaktır, ICustomerReadRepository interface'ini eklememizin nedeni IOC'den CustomerReadRepository sınıfını talep ederken
    // ICustomerReadRepository ile talep edecegimizden dolayi ve imzasi oldugunu belirtmektedir.

    //ReadRepository bizden paremetre talep etmekte constructorda => bu parametreyi bu sınıfın constroctur'inda veriyoruz.
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        //Const'un nesnesi IOC constan gelirken , base'e parametredeki context'i gondermek zorundayiz.
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
