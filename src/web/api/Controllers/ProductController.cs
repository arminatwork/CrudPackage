using System;
using System.Collections.Generic;
using api.Data.Repositories;
using api.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ActionResult<IEnumerable<Product>> GetProduct()
        {
            return _repository.GetByList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return NotFound($"Entity {id} not found! ...");

            return entity;
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            _repository.Add(product);
            return Ok(product);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Product> UpdateProduct(int id, Product product)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return NotFound($"Entity {id} not found! ...");

            entity.Name = product.Name ?? entity.Name;
            entity.Description = product.Description ?? entity.Description;
            entity.Price = product.Price;
            entity.UpdatedAt = DateTimeOffset.Now;

            _repository.Update(entity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return NotFound($"Entity {id} not found! ...");

            _repository.Delete(entity);

            return NoContent();
        }
    }
}
