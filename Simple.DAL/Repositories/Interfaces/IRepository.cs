using Microsoft.EntityFrameworkCore;
using Simple.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.DAL.Repositories.Interfaces
{
    public interface IRepository<T>  where T : BaseEntity, new()
    {
        
        Task<IQueryable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
        Task Create(T entity);
        void Update(T entity);

        void Delete(T entity);
        Task SaveChangesAsync();

    }
}
