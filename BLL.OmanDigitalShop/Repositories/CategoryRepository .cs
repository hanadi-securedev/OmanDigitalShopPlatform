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
    /// <summary>
    /// ريبوزيتوري الفئات
    /// يحتوي على جميع عمليات الفئات
    /// </summary>
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        // ============================================
        // Constructor
        // ============================================

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        // ============================================
        // عمليات خاصة بالفئات
        // ============================================

        /// <summary>
        /// الحصول على فئة مع منتجاتها
        /// </summary>
        public async Task<Category?> GetByIdWithProductsAsync(int id)
        {
            return await _dbSet
                .Include(c => c.Products) // جلب جميع المنتجات
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        /// <summary>
        /// الحصول على جميع الفئات مع عدد المنتجات
        /// </summary>
        public async Task<IEnumerable<Category>> GetAllWithProductCountAsync()
        {
            return await _dbSet
                .Include(c => c.Products)
                .ToListAsync();
        }

        /// <summary>
        /// الحصول على الفئات النشطة فقط
        /// </summary>
        public async Task<IEnumerable<Category>> GetActiveCategoriesAsync()
        {
            return await _dbSet
                .Where(c => c.IsActive)
                .ToListAsync();
        }

        /// <summary>
        /// التحقق من وجود فئة بنفس الاسم
        /// مفيد لتجنب تكرار أسماء الفئات
        /// </summary>
        public async Task<bool> ExistsByNameAsync(string name)
        {
            return await _dbSet
                .AnyAsync(c => c.Name.ToLower() == name.ToLower());
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
