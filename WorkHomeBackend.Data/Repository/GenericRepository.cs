using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WorkHomeBackend.Data.Context;
using WorkHomeBackend.Data.Repository.Interfaces;

namespace WorkHomeBackend.Data.Repository
{
    public class GenericRepository : IGenericRepository
    {
        private readonly WorkHomeContext _context;

        public GenericRepository(WorkHomeContext context)
        {
            _context = context;
        }

        public async Task<T> CreateAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<int> Delete<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync<T>(Expression<Func<T, bool>> whereCondition = null) where T : class
        {
            return await _context.Set<T>().Where(whereCondition).ToListAsync();
        }

        public async Task<T> GetByAsync<T>(Expression<Func<T, bool>> condition) where T : class
        {
            return await _context.Set<T>().Where(condition).FirstOrDefaultAsync();
        }

        public async Task<int> Update<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
