using BLL.OmanDigitalShop.Context;
using DAL.OmanDigitalShop.IProductReapstory;
using DAL.OmanDigitalShop.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.OmanDigitalShop.Repositories
{
    public class GenericRepository<T> : IGenericRepositery<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>(); // الحصول على الـ DbSet الخاص بالموديل T
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();
            return entity;

        }

        public Task DeleteAsync(int Id)
        {
            _context.Remove(_context.Set<T>().Find(Id)!);
            return _context.SaveChangesAsync();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = _context.Set<T>().AsEnumerable();
            return Task.FromResult(entities);
        }


        public Task<T> GetByIdAsync(int id)
        {
            var entity = _context.Set<T>().Find(id);
            return Task.FromResult(entity!);
        }

        public Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChangesAsync();
        }

        // ============================================
        // العمليات المساعدة - دوال جديدة
        // ============================================

        /// <summary>
        /// عد جميع الكيانات
        /// </summary>
        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        /// <summary>
        /// التحقق من وجود كيان بشرط معين
        /// </summary>
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }


    }
}
