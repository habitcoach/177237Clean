using Clean.Application.Interfaces;
using Clean.Application.Services;
using Clean.Infra.Data.Repository;
using CleanDomain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterService(this IServiceCollection Services) {

            Services.AddScoped<IProductService, ProductService>();


            Services.AddScoped<IProductRepository, ProductRepository>();

        }
    }
}
