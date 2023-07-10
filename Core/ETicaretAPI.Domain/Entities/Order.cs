using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        // n:n ilişki
        public ICollection<Product> Products { get; set; }
        // 1:n ilişki 
        public Customer Customer { get; set; }
    }
}
