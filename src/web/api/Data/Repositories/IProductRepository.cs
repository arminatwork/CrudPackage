using api.Models.Product;
using Crud.BaseRepository;

namespace api.Data.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}