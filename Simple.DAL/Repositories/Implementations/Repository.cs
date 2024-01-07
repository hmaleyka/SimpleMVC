using Microsoft.EntityFrameworkCore;
using Simple.Core.Base;
using Simple.DAL.DbContext;
using Simple.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _dbSet;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public DbSet<T> Table => _dbContext.Set<T>();
        
        public async Task Create(T entity)
        {
          await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            IQueryable<T> blogs = _dbSet;
            return blogs;
        }

        public async  Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
           await  _dbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
           _dbSet.Update (entity);
        }
    }
}
