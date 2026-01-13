using DAL.OmanDigitalShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL.OmanDigitalLyer.Interface
{
    /// <summary>
    /// واجهة خدمة الفئات
    /// </summary>
    public interface ICategoryService
    {
        // ============================================
        // عمليات القراءة
        // ============================================

        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<IEnumerable<Category>> GetActiveCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<Category?> GetCategoryWithProductsAsync(int id);

        // ============================================
        // عمليات الإنشاء والتحديث والحذف
        // ============================================

        Task<Category> CreateCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);

        // ============================================
        // عمليات مساعدة
        // ============================================

        Task<bool> CategoryExistsAsync(int id);
        Task<bool> CategoryNameExistsAsync(string name);
        Task<int> GetCategoriesCountAsync();
    }
}
