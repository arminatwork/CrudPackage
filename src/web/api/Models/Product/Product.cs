using api.Data.BaseEntity;

namespace api.Models.Product
{
    public class Product : BaseEntity
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
