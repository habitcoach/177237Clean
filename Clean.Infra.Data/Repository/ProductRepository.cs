using Clean.Infra.Data.Context;
using CleanDomain.Interfaces;
using CleanDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly RestaurantDBContext _context;

        public ProductRepository(RestaurantDBContext context)
        {
            this._context = context;
        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool AddProduct(Product product)
        {
           _context.Products.Add(product);
            _context.SaveChanges();

            return true;
        }
    }
}
