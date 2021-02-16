using System;
using api.Models.Product;

using Crud.BaseDTO;

namespace api.DTOs
{
    public class ProductDto : BaseDto<ProductDto, Product, int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }
    public class ProductSelectDto : BaseDto<ProductSelectDto, Product, int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
         public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}