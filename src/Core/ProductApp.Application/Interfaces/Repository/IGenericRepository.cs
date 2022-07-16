using System;
using ProductApp.Domain.Common;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<T> AddAsync(T entity);
    }
}

