using api.Data.Repositories;
using api.DTOs;
using api.Models.Product;

using AutoMapper;

using Crud.Controller;

namespace api.Controllers
{
    public class ProductController : BaseController<ProductDto, ProductSelectDto, Product, int>
    {
        public ProductController(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
