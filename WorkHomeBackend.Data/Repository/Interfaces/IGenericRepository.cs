using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkHomeBackend.Data.Repository.Interfaces
{
    public interface IGenericRepository
    {
        Task<List<T>> GetAllAsync<T>(Expression<Func<T, bool>> whereCondition = null) where T : class;
        Task<T> GetByAsync<T>(Expression<Func<T, bool>> condition) where T : class;
        Task<int> Delete<T>(T entity) where T : class;
        Task<int> Update<T>(T entity) where T : class;
        Task<T> CreateAsync<T>(T entity) where T : class;
    }
}
