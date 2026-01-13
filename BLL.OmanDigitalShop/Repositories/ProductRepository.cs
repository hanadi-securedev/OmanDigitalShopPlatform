using BLL.OmanDigitalShop.Context;
using DAL.OmanDigitalShop.Interface;
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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        


        // ============================================
        // Constructor
        // ============================================

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        // ============================================
        // عمليات خاصة بالمنتجات
        // ============================================

        /// <summary>
        /// الحصول على جميع المنتجات مع الفئات
        /// نستخدم Include لجلب الفئة مع كل منتج
        /// </summary>
        public async Task<IEnumerable<Product>> GetAllWithCategoryAsync()
        {
            return await _dbSet
                .Include(p => p.Category) // جلب الفئة المرتبطة
                .ToListAsync();
        }

        /// <summary>
        /// الحصول على منتج مع الفئة
        /// </summary>
        public async Task<Product?> GetByIdWithCategoryAsync(int id)
        {
            return await _dbSet
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        /// <summary>
        /// الحصول على منتجات فئة معينة
        /// </summary>
        public async Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId)
        {
            return await _dbSet
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .ToListAsync();
        }

        /// <summary>
        /// الحصول على المنتجات النشطة فقط
        /// </summary>
        public async Task<IEnumerable<Product>> GetActiveProductsAsync()
        {
            return await _dbSet
                .Where(p => p.IsActive)
                .Include(p => p.Category)
                .ToListAsync();
        }

        /// <summary>
        /// البحث في المنتجات بالاسم
        /// </summary>
        public async Task<IEnumerable<Product>> SearchByNameAsync(string searchTerm)
        {
            return await _dbSet
                .Where(p => p.Name.Contains(searchTerm))
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Categories.CountAsync();
        }

        // ✅ تطبيق ExistsAsync
        public async Task<bool> ExistsAsync(Expression<Func<Category, bool>> predicate)
        {
            return await _context.Categories.AnyAsync(predicate);
        }

    }
}
