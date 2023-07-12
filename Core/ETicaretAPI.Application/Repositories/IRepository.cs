using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Bütün repository'ler içerisinde olması gereken ortak olan şeyler buraya yazılır.
        DbSet<T> Table { get; } 
    }
}
