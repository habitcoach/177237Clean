using Clean.Application.DTOs;
using CleanDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Interfaces
{
    public interface IProductService
    {
        public Dto GetProductsDto();
        public bool CreateProduct(ProductDto productDto);
    }
}
