using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkHomeBackend.Common.Responses;

namespace WorkHomeBackend.Services.Services.Interfaces
{
    public interface ICrud<T>
    {
        Task<Response<List<T>>> GetAll();
        Task<Response<T>> Create(T entity);
        Task<Response<T>> GetById(Guid id);
        Task<Response<bool>> Update(T entity);
        Task<Response<bool>> Delete(Guid id);
    }
}
