using Academy.Core.Models.BaseModels;
using Academy.Core.Repositories;
using System;

namespace Academy.Data.Repositores
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(Func<T, bool> func)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Func<T, bool> func)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
