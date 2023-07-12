using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Repositories //Name space'de enntity ismini silmez isek asagidaki entity referansını yakalayamıyoruz.
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
    }
}
