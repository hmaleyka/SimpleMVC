using Simple.Business.ViewModels;
using Simple.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Business.Services.Interfaces
{
    public interface IProductService
    {
        Task<ICollection<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> Create(CreateProductVM category ,string path);
        Task<Product> Update(CreateProductVM category);

        Task<Product> Delete(CreateProductVM category);
    }
}

