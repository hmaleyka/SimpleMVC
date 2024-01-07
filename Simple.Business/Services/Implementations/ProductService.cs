using Microsoft.EntityFrameworkCore;
using Simple.Business.Services.Interfaces;
using Simple.Business.ViewModels;
using Simple.Core.Models;
using Simple.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Business.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<Product> Create(CreateProductVM product , string path)
        {
            Product products = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                ImgUrl = path
            };
            await _repo.Create(products);
            await _repo.SaveChangesAsync();
            return products;
        }

        public Task<Product> Delete(CreateProductVM category)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Product>> GetAllAsync()
        {
            var products = await _repo.GetAllAsync();
            return await products.ToListAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(CreateProductVM category)
        {
            throw new NotImplementedException();
        }
    }
}
