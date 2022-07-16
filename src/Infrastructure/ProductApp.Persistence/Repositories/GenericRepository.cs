using System;
using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;

namespace ProductApp.Persistence.Repositories
{
    public class GenericRepository<T>:IGenericRepository<T> where T :BaseEntity
    {
        ApplicationDbContext DbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await DbContext.Set<T>().FindAsync(Id);
        }
    }
}

