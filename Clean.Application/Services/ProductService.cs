using Clean.Application.DTOs;
using Clean.Application.Interfaces;
using CleanDomain.Interfaces;
using CleanDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository ProductRepository)
        {
            _productRepository = ProductRepository;
        }

        public bool CreateProduct(ProductDto productDto)
        {
            Product product = new Product()
            {

                Name = productDto.Name,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                Price = productDto.Price

            };

             var result = _productRepository.AddProduct(product);

            return result;

        }

        public Dto GetProductsDto()
        {
            return new Dto()
            {

                Products = _productRepository.GetProducts()

            };
        }
    }
}
